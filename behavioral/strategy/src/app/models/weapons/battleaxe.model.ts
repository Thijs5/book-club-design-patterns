import { Attackable } from '../attackable';

export class Battleaxe {
  id = 'battleaxe';
  strength = 48;
  speed = 6;

  slash(character: Attackable) {
    character.slash(this.strength);
  }
}
