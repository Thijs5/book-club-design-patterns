import { Attackable } from '../attackable';
import { Defence } from '../defence.model';
import { calculateDamage } from '../weapons/calculateDamage';
import { IWithHealth } from '../with-health';

export class Monster implements IWithHealth, Attackable {
  get currentHealth() { return this._currentHealth; }
  set currentHealth(n: number) {
    const newHealth = n < 0 ? 0 : n;
    if (newHealth === 0) {
      console.clear();
    }
    this._currentHealth = newHealth;
  }

  get isAlive(): boolean {
    return this.currentHealth > 0;
  }
  readonly id: string;
  baseHealth: number;
  damage: number;
  speed: number;
  defence: Defence;

  _currentHealth: number;

  stab(strength: number) {
    const damage = calculateDamage(strength, this);
    this.takeDamage(damage);
  }
  crush(strength: number) {
    const damage = calculateDamage(strength, this);
    this.takeDamage(damage);
  }
  slash(strength: number) {
    const damage = calculateDamage(strength, this);
    this.takeDamage(damage);
  }

  revive() {
    this.currentHealth = this.baseHealth;
  }

  private takeDamage(damage: number) {
    this.currentHealth = this.currentHealth - damage;
  }
}
