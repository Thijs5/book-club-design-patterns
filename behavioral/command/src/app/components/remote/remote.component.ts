import { Component, EventEmitter, Input, Output } from '@angular/core';
import { ICommand, MoveUpCommand, MoveDownCommand, TogglePowerCommand } from 'src/app/models/commands';
import { Television } from 'src/app/models/television';
import { ButtonCode } from '../../models/button-codes';

@Component({
  selector: 'app-remote',
  templateUrl: './remote.component.html',
  styleUrls: ['./remote.component.scss']
})
export class RemoteComponent {
  @Output() onPress = new EventEmitter<ICommand>();

  @Input() television: Television;

  get commandMap(): any {
    return {
      [ButtonCode.Up]: new MoveUpCommand(this.television),
      [ButtonCode.Down]: new MoveDownCommand(this.television),
      [ButtonCode.Power]: new TogglePowerCommand(this.television),
    };
  }

  public get ButtonCode(): typeof ButtonCode {
    return ButtonCode;
  }

  press(code: ButtonCode) {
    const command = this.commandMap[code];
    if (command) {
      this.onPress.next(command);
    } else {
      console.error(`Command ${code} not yet implemented.`);
    }
  }

}
