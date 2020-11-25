import { Defence } from '../defence.model';
import { Monster } from './monster.model';

export class GreenDragon extends Monster {
  readonly id = 'green_dragon';

  constructor() {
    super();
    this.baseHealth = 75;
    this.currentHealth = this.baseHealth;
    this.defence = new Defence({
      baseDefence: 68,
      stabDefence: 10,
      slashDefence: 40,
      crushDefence: 40,
    });
  }
}
