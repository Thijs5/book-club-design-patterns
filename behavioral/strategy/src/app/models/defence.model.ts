
export class Defence {
  baseDefence: number;
  stabDefence: number;
  slashDefence: number;
  crushDefence: number;

  constructor(init?: Partial<Defence>) {
    if (init) {
      Object.assign(this, init);
    }
  }
}
