import { Calculator } from './calculator.model';


describe('Calculator.parse', () => {
  const calculator = new Calculator();
  const parse = calculator.parse.bind(calculator);

  describe('basic operations', () => {
    it ('+', () => { expect(parse('50 + 5')).toBe(55); });
    it ('-', () => { expect(parse('55 - 5')).toBe(50); });
    it ('*', () => { expect(parse('10 * 5')).toBe(50); });
    it ('/', () => { expect(parse('50 / 5')).toBe(10); });
  });

  describe('combined operations +', () => {
    it ('++', () => { expect(parse('50 + 5 + 5')).toBe(60); });
    it ('+-', () => { expect(parse('55 + 5 - 5')).toBe(55); });
    it ('+*', () => { expect(parse('10 + 5 * 5')).toBe(35); });
    it ('+/', () => { expect(parse('50 + 5 / 5')).toBe(51); });

    it ('-+', () => { expect(parse('50 - 5 + 5')).toBe(50); });
    it ('--', () => { expect(parse('55 - 5 - 5')).toBe(45); });
    it ('-*', () => { expect(parse('10 - 5 * 5')).toBe(-15); });
    it ('-/', () => { expect(parse('50 - 5 / 5')).toBe(49); });
  });

});
