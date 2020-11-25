import { Component } from '@angular/core';
import { Hero } from './models/hero.model';
import { GreenDragon } from './models/monsters/green-dragon.model';
import { Battleaxe } from './models/weapons/battleaxe.model';
import { Dagger } from './models/weapons/dagger.model';
import { DragonHunterSpear } from './models/weapons/dragon-hunter-spear.model';
import { Scimitar } from './models/weapons/scimitar.model';
import { TwoHandSword } from './models/weapons/two-hand-sword.model';
import { Warhammer } from './models/weapons/warhammer.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  hero: Hero;
  monster = new GreenDragon();
  // weapons = [
  //   new Dagger(),
  //   new Scimitar(),
  //   new Battleaxe(),
  //   new Warhammer(),
  //   new TwoHandSword(),
  //   // new DragonHunterSpear(),
  // ];
  weapons = null;


  constructor() {
    this.hero = new Hero();
  }

  onAttack() {
    this.hero.stab(this.monster);
  }

  onChangeWeapon(weapon: any) {
    console.log('TODO - change weapon');
  }
}
