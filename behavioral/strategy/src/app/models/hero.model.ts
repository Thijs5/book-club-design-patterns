import { Attackable } from './attackable';
import { Dagger } from './weapons/dagger.model';
import { IWithHealth } from './with-health';

export class Hero implements IWithHealth {
  baseHealth: number;
  currentHealth: number;
  dagger: Dagger;

  constructor() {
    this.baseHealth = 99;
    this.currentHealth = this.baseHealth;
    this.dagger = new Dagger();
  }

  stab(character: Attackable) {
    this.dagger.stab(character);
  }

  get weaponId() {
    return this.dagger.id;
  }
}
