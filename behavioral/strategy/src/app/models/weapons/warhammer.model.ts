import { Attackable } from '../attackable';

export class Warhammer {
  id = 'warhammer';
  strength = 53;
  speed = 6;

  crush(character: Attackable) {
    character.crush(this.strength);
  }
}
