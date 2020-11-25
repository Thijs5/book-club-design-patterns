import { Defence } from './defence.model';

export interface Attackable {
  defence: Defence;
  stab(strength: number);
  crush(strength: number);
  slash(strength: number);
}
