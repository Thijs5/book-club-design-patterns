import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subject } from 'rxjs';
import { Restaurant } from 'src/domain/restaurant.model';
import { LogService, Message } from './log.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit, OnDestroy {
  title = 'facade';

  events: Message[] = [];
  #loggerSubscription: Subject<Message>;

  #restaurant: Restaurant;

  constructor(private logger: LogService) {
    this.#loggerSubscription = logger.message;
    this.#restaurant = new Restaurant(logger);
  }

  order() {
    this.#restaurant.order();
  }

  ngOnInit(): void {
    this.#loggerSubscription.subscribe((x: Message) => this.events.push(x))
  }

  ngOnDestroy(): void {
    this.#loggerSubscription.unsubscribe();
  }
}
