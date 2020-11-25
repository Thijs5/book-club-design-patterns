import { Component, Input } from '@angular/core';
import { Hero } from '../models/hero.model';

@Component({
  selector: 'app-hero',
  styles: [`
    .wrapper {
      margin-top: 1rem;
    }
    img {
      margin-top: 0.5rem;
      max-height: 50vh;
    }
  `],
  template: `
    <div class="wrapper">
      <app-health-bar [value]="hero"></app-health-bar>
      <img [src]="heroImage" />
    </div>
  `,
})
export class HeroComponent {
  @Input() hero: Hero;

  get heroImage(): string {
    return `assets/weapons/${this.hero.weaponId}/${this.hero.weaponId}_equipped.png`;
  }
}
