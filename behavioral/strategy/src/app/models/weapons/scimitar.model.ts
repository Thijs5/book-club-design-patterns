import { Attackable } from '../attackable';

export class Scimitar {
  id = 'scimitar';
  strength = 45;
  speed = 4;

  slash(character: Attackable) {
    character.slash(this.strength);
  }
}
