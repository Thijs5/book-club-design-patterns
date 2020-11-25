import { EventEmitter } from '@angular/core';
import { Component, Input, Output } from '@angular/core';
import { Battleaxe } from '../models/weapons/battleaxe.model';
import { Dagger } from '../models/weapons/dagger.model';
import { Scimitar } from '../models/weapons/scimitar.model';

@Component({
  selector: 'app-weapon-switcher',
  styles: [`
    h2 { color: white; }
    .wrapper {
      display: flex;
      flex-direction: column;
    }
    .weapons-list {
      display: flex;
      flex-direction: row;
    }
    .weapon {
      cursor: pointer;
      margin: 1rem;
      padding: 1rem;
      display: inline-block;
    }
    .weapon:hover {
      background: rgba(255, 255, 255, 0.2);
    }
    .weapon img {
      flex: 0 0 auto;
      max-height: 10rem;
    }
  `],
  template: `
    <div class="wrapper">
      <h2>Change weapon</h2>
      <div class="weapon-list">
        <ng-container *ngFor="let weapon of weapons">
          <a class="weapon" (click)="changeWeapon.emit(weapon)" >
            <img [src]="imgSrc(weapon.id)" />
          </a>
        </ng-container>
      </div>
    </div>
  `,
})
export class WeaponSwitcherComponent {
  dagger: Dagger;
  battleaxe: Battleaxe;
  scimitar: Scimitar;

  @Input() weapons: any[];
  @Output() changeWeapon = new EventEmitter<any>();

  constructor() {
    this.dagger = new Dagger();
    this.battleaxe = new Battleaxe();
    this.scimitar = new Scimitar();
  }

  imgSrc(weaponId: string) {
    return `assets/weapons/${weaponId}/${weaponId}_detail.png`;
  }
}
