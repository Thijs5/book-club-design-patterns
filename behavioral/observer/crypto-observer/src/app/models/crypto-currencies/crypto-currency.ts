import { IObserver } from '../observers/observer';

export abstract class CryptoCurrency {
  public price: number;

  constructor(price: number) {
    this.price = price;
  }
}
