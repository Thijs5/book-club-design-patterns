import { Constant } from './constant.model';
import { Expression } from './expression.model';
import { Division, Minus, Operation, Product, Sum } from './operation.model';

export class Calculator {
  #treeBuilder = new TreeBuilder();

  constructor() { }

  parse(expression: string): number {
    const result = this.#treeBuilder.createExpression(expression);
    return result.getValue();
  }
}

interface OperatorOrder {
  operator: string;
  order: number;
}

class TreeBuilder {
  #operators: ReadonlyArray<OperatorOrder> = [
    { operator: '*', order: 3 },
    { operator: '/', order: 3 },
    { operator: '+', order: 4 },
    { operator: '-', order: 4 },
  ];

  createExpression(expression: string): Expression {
    const indexOfNextOperator = this.#indexOfNextOperator(expression);

    if (indexOfNextOperator !== -1) {
      const operator = expression[indexOfNextOperator];
      return this.createOperation(
        operator,
        expression.substr(0, indexOfNextOperator).trim(),
        expression.substr(indexOfNextOperator + 1, expression.length).trim()
      );
    } else {
      return new Constant(parseFloat(expression));
    }
  }

  createOperation(operator: string, left: string, right: string): Operation {
    switch (operator) {
      case '+': return new Sum(this.createExpression(left), this.createExpression(right));
      case '-': return new Minus(this.createExpression(left), this.createExpression(right));
      case '*': return new Product(this.createExpression(left), this.createExpression(right));
      case '/': return new Division(this.createExpression(left), this.createExpression(right));
      default: throw Error(`calculation '${left} ${operator} ${right}' not supported`);
    }
  }

  #indexOfNextOperator = (expression: string): number => {
    for (let order = 4; order >= 1; order--) {
      const index = this.#indexOfOrderOperator(expression, order);
      if (index !== -1) {
        return index;
      }
    }
    return -1;
  }

  #indexOfOrderOperator = (expression: string, order: number): number => {
    return this.#operators
      .filter(o => o.order === order)
      .map(o => o.operator)
      .reduce((acc, cur) => {
        const lastIndex = expression.lastIndexOf(cur);
        return Math.max(acc, lastIndex);
      }, -1);
  }
}
