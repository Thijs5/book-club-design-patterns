import { Attackable } from '../attackable';

export class DragonHunterSpear {
  id = 'dragon_hunter_spear';
  strength = 55;
  speed = 6;

  stab(character: Attackable) {
    character.stab(this.strength);
  }
}
