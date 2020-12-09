import { Component, OnInit } from '@angular/core';
import { ChristmasTreeImpl } from './models/ChristmasTreeImpl';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Christmas tree';

  tree = new ChristmasTreeImpl();

  decorations: string[] = [];

  ngOnInit(): void {
    this.executeChristmas();
  }


  public executeChristmas() {
    // Decorate your tree with some lights, balls and a star here
  }
}
