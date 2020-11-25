import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { FightComponent } from './components/fight.component';
import { LocationComponent } from './components/location.component';
import { HeroComponent } from './components/hero.component';
import { HealthBarComponent } from './components/health-bar.component';
import { MonsterComponent } from './components/monster.component';
import { WeaponSwitcherComponent } from './components/weapon-switcher.component';

@NgModule({
  declarations: [
    AppComponent,
    FightComponent,
    LocationComponent,
    HeroComponent,
    HealthBarComponent,
    MonsterComponent,
    WeaponSwitcherComponent,
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
