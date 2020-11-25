import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { interval, of } from 'rxjs';
import {  delay, finalize, takeUntil, takeWhile } from 'rxjs/operators';
import { Hero } from '../models/hero.model';
import { Monster } from '../models/monsters/monster.model';

@Component({
  selector: 'app-fight',
  styles: [`
    .fight {
      display: flex;
      flex-direction: column;
    }
    .arena {
      display: flex;
      flex-direction: row;
      justify-content: space-around;
    }
  `],
  template: `
    <app-location>
      <div class="fight">

        <div class="arena">
          <app-hero [hero]="hero" [style.marginLeft]="heroMargin"></app-hero>
          <app-monster
            [style.visibility]="showMonster ? 'inherit' : 'hidden'"
            [monster]="monster"
            (attack)="startAttacking()"
            [isUnderAttack]="isFighting">
          </app-monster>
        </div>

        <app-weapon-switcher
          *ngIf="weapons && weapons.length > 0"
          [weapons]="weapons"
          (changeWeapon)="changeWeapon.emit($event)"
        ></app-weapon-switcher>

      </div>
    </app-location>
  `,
})
export class FightComponent {

  @Input() hero: Hero;
  @Input() monster: Monster;
  @Input() weapons: any[];

  @Output() changeWeapon = new EventEmitter<any>();
  @Output() attack = new EventEmitter();

  heroMargin: string;

  showMonster = true;
  isFighting: boolean;

  startAttacking() {
    this.isFighting = true;
    interval(600 * this.hero.dagger.speed)
      .pipe(
        takeWhile(() => this.monster.isAlive),
        finalize(() => { this.monsterDied(); })
      )
      .subscribe(_ => {
        this.animateHero();
        this.attack.emit();
      });
  }

  private animateHero() {
    this.heroMargin = '3rem';
    of(true).pipe(delay(250)).subscribe(_ => { this.heroMargin = '0'; });
  }
  private monsterDied() {
    this.isFighting = false;
    of(true).pipe(delay(500)).subscribe(_ => { this.showMonster = false; });
    of(true).pipe(delay(5000)).subscribe(_ => { this.monster.revive(); this.showMonster = true; });
  }
}
