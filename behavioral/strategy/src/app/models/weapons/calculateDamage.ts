import { Attackable } from '../attackable';

const logDamage = (damage: number) => {
  const background = damage === 0
    ? 'blue'
    : 'red';

  console.log(`%c${damage}`, `font-size: 2rem; color: white; background: ${background}; padding: 3px;`);
};

export const calculateDamage = (weaponStrength: number, character: Attackable): number => {
  const randomFactor = Math.random();
  const resistanceFactor = (character.defence.baseDefence + character.defence.stabDefence) / 100;
  const damage = Math.floor((weaponStrength - (weaponStrength * resistanceFactor)) * randomFactor);
  logDamage(damage);
  return damage;
};

