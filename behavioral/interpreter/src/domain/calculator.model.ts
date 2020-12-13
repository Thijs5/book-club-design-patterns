export class Calculator {
  parse(expression: string, separator: string = ' '): number {
    const parts = expression.split(separator);
    let result = parseFloat(parts[0]);

    for (let i = 1; i < parts.length; i++) {
      const part = parseFloat(parts[i]);
      if (this.isOperator(part)) {
        result = this.calculate(result, parts[i], parseFloat(parts[i + 1]));
        i++;
      }
    }

    return result;
  }

  private calculate(n1: number, operator: string, n2: number): number {
    switch (operator) {
      case '+': return n1 + n2;
      case '-': return n1 - n2;
      case '*': return n1 * n2;
      case '/': return n1 / n2;
      default: throw Error(`calculation '${n1} ${operator} ${n2}' not supported`);
    }
  }

  private isOperator(n: number): boolean {
    return isNaN(n);
  }
}
