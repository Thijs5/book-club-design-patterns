import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subject } from 'rxjs';
import { Kitchen } from 'src/domain/kitchen.model';
import { Waiter } from 'src/domain/waiter.model';
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

  #waiter: Waiter;
  #kitchen: Kitchen;

  constructor(private logger: LogService) {
    this.#loggerSubscription = logger.message;
    this.#waiter = new Waiter(logger);
    this.#kitchen = new Kitchen(logger);
  }

  order() {
    this.#waiter.writeOrder();
    this.#waiter.sendToKitchen();
    this.#kitchen.processOrder();
    this.#waiter.serveCustomer();
    this.#kitchen.washDishes();
  }

  ngOnInit(): void {
    this.#loggerSubscription.subscribe((x: Message) => this.events.push(x))
  }

  ngOnDestroy(): void {
    this.#loggerSubscription.unsubscribe();
  }
}
