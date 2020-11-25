import { Component, Input } from '@angular/core';
import { IWithHealth } from '../models/with-health';

@Component({
  selector: 'app-health-bar',
  styles: [`
    /* :host {
      width: 100%;
    } */
    .outer {
      width: 100%;
      height: 1.2rem;
      background-color: red;
    }
    .inner {
      height: 1.2rem;
      background-color: green;
    }
    .text {
      position: absolute;
      color: white;
    }
  `],
  template: `
    <div class="outer">
      <div class="inner" [style.width]="innerWith + '%'">
        <div class="text">
          {{ this.value.currentHealth }}/{{ this.value.baseHealth }}
        </div>
      </div>
    </div>
  `,
})
export class HealthBarComponent {
  @Input() value: IWithHealth;

  get innerWith(): number {
    if (this.value.currentHealth <= 0) { return 0; }
    return Math.round(this.value.currentHealth * 100 / this.value.baseHealth);
  }
}
