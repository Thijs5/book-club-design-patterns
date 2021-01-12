import { Expression } from './expression.model';

export abstract class Operation implements Expression {
  left: Expression;
  right: Expression;
  abstract getValue(): number;

  constructor(left: Expression, right: Expression) {
    this.left = left;
    this.right = right;
  }
}

export class Sum extends Operation {
  constructor(left: Expression, right: Expression) {
    super(left, right);
  }

  getValue(): number {
    return this.left.getValue() + this.right.getValue();
  }
}

export class Minus extends Operation {
  constructor(left: Expression, right: Expression) {
    super(left, right);
  }

  getValue(): number {
    return this.left.getValue() - this.right.getValue();
  }
}

export class Product extends Operation {
  constructor(left: Expression, right: Expression) {
    super(left, right);
  }

  getValue(): number {
    return this.left.getValue() * this.right.getValue();
  }
}

export class Division extends Operation {
  constructor(left: Expression, right: Expression) {
    super(left, right);
  }

  getValue(): number {
    return this.left.getValue() / this.right.getValue();
  }
}
