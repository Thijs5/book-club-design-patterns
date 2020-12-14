# Interpreter

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 11.0.4.

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.

Run `ng test` to run the tests. Since the calculator doesn't yet calculates correclty, some tests will fail.

## Exercise
We're roleplaying as the Windows calculator developing team. When writing tests we discovered our calculator doesn't take in account the order of calculation.

![calculator](https://raw.githubusercontent.com/Thijs5/book-club-design-patterns/master/behavioral/interpreter/src/assets/calculator.png)

The goal of the exercise is to refactor the `calculator`-class using the interpreter pattern. By using an interpreter pattern our calculator should adhire to the mathical order of execution rules. As a reminder:

- A mathematical expression is read from left to right
- Multiple and division should be executed before addition and subtraction

### Example
Consider the equation `12 / 4 + 5 * 3 - 6`. The naive calculator will calculate this from left to right and return `18`. The actual solution should be `12`.

#### Naive
- 12 / 4 + 5 * 3 - 6
- `3` + 5 * 3 - 6
- `8` * 3 - 6
- `24` - 6
- `18`

#### Correct
- 12 / 4 + 5 * 3 - 6
- `3` + 5 * 3 - 6
- 3 + `15` - 6
- `18` - 6
- `12`

### Solution
The interpreter pattern relies on an abstract `Expression` base-class.
```typescript
export interface Expression {
  /**
   * Calculate the result of the expression.
   */
  getValue(): number;
}
```
The interpreter pattern normally has 2 subclasses of `Expression`, a terminal class and a non-terminal class. In our example we a `Constant` (terminal) and an `Operation` (non-terminal). `Operation` is the base class for all the supported operations.

```typescript
export class Constant implements Expression {
  value: number;

  constructor(value: number) {
    this.value = value;
  }

  getValue(): number {
    return this.value;
  }
}

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
```

The most diffucult part of this exercises is to construct a binary tree of the expression. For the example give, the tree should like the tree below. Not that the more priority an operator has, the lower in the tree it should be. 

![tree](https://raw.githubusercontent.com/Thijs5/book-club-design-patterns/master/behavioral/interpreter/src/assets/binary-tree.png)

