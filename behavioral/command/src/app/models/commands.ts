import { Television } from "./television";

export interface ICommand {
  execute(): void;
}

export class MoveUpCommand implements ICommand {
  constructor(private television: Television) {  }

  public execute(): void {
    if (this.television.isPoweredOn) {
      this.television.MoveUp();
    }
  }
}

export class MoveDownCommand implements ICommand {
  constructor(private television: Television) {  }

  public execute(): void {
    if (this.television.isPoweredOn) {
      this.television.MoveDown();
    }
  }
}

export class TogglePowerCommand implements ICommand {
  constructor(private television: Television) {  }

  public execute(): void {
    this.television.ToggleOn();
  }
}
