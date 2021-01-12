import { Calculator } from './calculator.model';


describe('Calculator.parse', () => {
  const calculator = new Calculator();
  const parse = calculator.parse.bind(calculator);

  describe('basic operations', () => {
    it ('3 + 3', () => { expect(parse('3 + 3')).toBe(6); });
    it ('3 - 3', () => { expect(parse('3 - 3')).toBe(0); });
    it ('3 * 3', () => { expect(parse('3 * 3')).toBe(9); });
    it ('3 / 3', () => { expect(parse('3 / 3')).toBe(1); });
  });

  describe('combined operations', () => {
    it ('3 + 3 + 3', () => { expect(parse('3 + 3 + 3')).toBe(9); });
    it ('3 + 3 - 3', () => { expect(parse('3 + 3 - 3')).toBe(3); });
    it ('3 + 3 * 3', () => { expect(parse('3 + 3 * 3')).toBe(12); });
    it ('3 + 3 / 3', () => { expect(parse('3 + 3 / 3')).toBe(4); });

    it ('3 - 3 + 3', () => { expect(parse('3 - 3 + 3')).toBe(3); });
    it ('3 - 3 - 3', () => { expect(parse('3 - 3 - 3')).toBe(-3); });
    it ('3 - 3 * 3', () => { expect(parse('3 - 3 * 3')).toBe(-6); });
    it ('3 - 3 / 3', () => { expect(parse('3 - 3 / 3')).toBe(2); });

    it ('12 / 4 + 5 * 3 - 6', () => { expect(parse('12 / 4 + 5 * 3 - 6')).toBe(12); });
  });

});
