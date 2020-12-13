import { Component } from '@angular/core';
import { Calculator } from 'src/domain/calculator.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'interpreter';

  private calculator: Calculator;
  private lastAction?: 'number' | 'operator';

  calculation = '';
  result?: number;

  constructor() {
    this.calculator = new Calculator();
  }

  operator(op: string): void {
    if (this.lastAction === undefined) { return; }
    if (this.lastAction === 'operator') {
      this.calculation = this.calculation.slice(0, -3);
    }
    this.calculation += ` ${op} `;
    this.lastAction = 'operator';
  }

  number(n: number | string): void {
    this.calculation += `${n}`;
    this.lastAction = 'number';
  }

  calculate(): void {
    if (this.isValidExpression) {
      this.result = this.calculator.parse(this.calculation);
    }
  }

  get isValidExpression(): boolean {
    return this.calculation[this.calculation.length - 1] !== '';
  }

  reset(): void {
    this.result = undefined;
    this.calculation = '';
  }

  private notSupported(): void {
    alert('feature not yet supported.');
  }
}
