import { Component, OnInit } from '@angular/core';
import { ChristmasTreeImpl } from './models/ChristmasTreeImpl';
import { Lights } from './models/Lights';
import { Balls } from './models/Balls';
import { Star } from './models/Star';

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
    this.decorations = this.tree.decorate();

    // this.decorations = new Star(new Balls(new Lights(this.tree))).decorate();
  }
}
