import { CryptoCurrency } from '../crypto-currencies/crypto-currency';
import { IObserver } from './observer';

export class Person implements IObserver {
  name: string;
  happiness: Happiness = Happiness.Happy;
  buyInPrice: number;
  profit: number;

  constructor(name: string) {
    this.name = name;
    this.buyInPrice = Math.floor(Math.random() * 50);
  }

  update(cryptoCurrency: CryptoCurrency): void {
    this.profit = cryptoCurrency.price - this.buyInPrice;

    if (this.profit >= 0) {
      this.happiness = Happiness.Happy;
    }
    else if (this.profit < 0) {
      this.happiness = Happiness.Sad;
    }
  }

  get isHappy(): boolean {
    return this.happiness === Happiness.Happy;
  }

  get isSad(): boolean {
    return this.happiness === Happiness.Sad;
  }
}


export enum Happiness {
  Sad = 1,
  Happy = 2,
}
