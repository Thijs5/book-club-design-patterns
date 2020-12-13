import { Expression } from './expression.model';

export class Constant implements Expression {
  value: number;

  constructor(value: number) {
    this.value = value;
  }

  getValue(): number {
    return this.value;
  }
}
