import { IObserver } from '../observers/observer';

export abstract class CryptoCurrency {
  private priceState: number;
  private observers: IObserver[] = [];

  constructor(price: number) {
    this.priceState = price;
  }

  public get price() {
    return this.priceState;
  }
  public set price(price: number) {
    if (this.priceState !== price) {
      this.priceState = price;
      this.notify();
    }
  }

  public attach(observer: IObserver): void {
    this.observers.push(observer);
  }

  public detach(observer: IObserver) {
    this.observers = this.observers.filter(obs => obs.name !== observer.name);
  }

  public notify(): void {
    this.observers.forEach(obs => obs.update(this));
  }
}
