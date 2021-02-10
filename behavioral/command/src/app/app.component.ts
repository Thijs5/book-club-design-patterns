import { Component, OnInit } from '@angular/core';
import { ICommand } from './models/commands';
import { Television } from './models/television';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  title = 'command';

  public television: Television;

  public withRemote = true;

  buttonPress(command: ICommand) {
    command.execute();
  }

  ngOnInit(): void {
    this.television = new Television();
  }
}
