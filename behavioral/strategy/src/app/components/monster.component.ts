import { Component, EventEmitter, Input, OnChanges, Output, SimpleChanges } from '@angular/core';
import { Monster } from '../models/monsters/monster.model';

@Component({
  selector: 'app-monster',
  styles: [`
    .wrapper {
      cursor: pointer;
      margin-top: 1rem;
    }
    .wrapper:hover {
      background: rgba(255, 255, 255, 0.2);
    }
    .underAttack {
      -webkit-animation: flickerAnimation 1s infinite;
      -moz-animation: flickerAnimation 1s infinite;
      -o-animation: flickerAnimation 1s infinite;
        animation: flickerAnimation 1s infinite;
    }
    @keyframes flickerAnimation {
      0%   { opacity:1; }
      50%  { opacity:0.5; }
      100% { opacity:1; }
    }
    @-o-keyframes flickerAnimation{
      0%   { opacity:1; }
      50%  { opacity:0.5; }
      100% { opacity:1; }
    }
    @-moz-keyframes flickerAnimation{
      0%   { opacity:1; }
      50%  { opacity:0.5; }
      100% { opacity:1; }
    }
    @-webkit-keyframes flickerAnimation{
      0%   { opacity:1; }
      50%  { opacity:0.5; }
      100% { opacity:1; }
    }
    img {
      margin-top: 1rem;
      max-height: 50vh;
    }
  `],
  template: `
    <div class="wrapper" [style.opacity]="monster.isAlive ? '1' : '0.3'">
      <app-health-bar [value]="monster"></app-health-bar>
      <img [src]="imageSrc" [class.underAttack]="isUnderAttack" (click)="emitAttack()" />
    </div>
  `,
})
export class MonsterComponent {

  get imageSrc(): string {
    return `assets/monsters/${this.monster.id}.png`;
  }
  @Input() monster: Monster;
  @Input() isUnderAttack;

  @Output() attack = new EventEmitter();

  emitAttack() {
    if (!this.attack.isStopped) {
      this.attack.emit();
    }
    this.attack.unsubscribe();
  }
}
