import { Attackable } from '../attackable';

export class Dagger {
  id = 'dagger';
  strength = 25;
  speed = 4;

  stab(character: Attackable) {
    character.stab(this.strength);
  }
}
