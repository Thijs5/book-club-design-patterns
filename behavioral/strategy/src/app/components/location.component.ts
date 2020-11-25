import { Component } from '@angular/core';

@Component({
  selector: 'app-location',
  styles: [`
    .wrapper {
      width: 100%;
      height: 100%;
      display: flex;
      flex: 1;
      flex-direction: column;
      background-image: url('assets/locations/wilderness.png');
      background-position: center;
      background-repeat: no-repeat;
      background-size: cover;
    }`],
  template: `
    <div class="wrapper">
      <ng-content class="content"></ng-content>
    </div>
  `,
})
export class LocationComponent { }
