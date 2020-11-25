import { Attackable } from '../attackable';

export class TwoHandSword {
  id = '2h_sword';
  strength = 69;
  speed = 7;

  crush(character: Attackable) {
    character.crush(this.strength);
  }
}
