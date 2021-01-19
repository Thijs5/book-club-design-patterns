import { Component, OnDestroy, OnInit } from '@angular/core';
import { Observable, Subject } from 'rxjs';
import { Chef } from 'src/domain/chef.model';
import { Microwave } from 'src/domain/microwave.model';
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

  #chef: Chef;
  #microwave: Microwave
  #waiter: Waiter;

  constructor(private logger: LogService) {
    this.#loggerSubscription = logger.message;
    this.#chef = new Chef(logger);
    this.#waiter = new Waiter(logger);
    this.#microwave = new Microwave(logger);
  }

  order() {
    this.#waiter.writeOrder();
    this.#waiter.sendToKitchen();
    this.#chef.receiveOrder();
    this.#microwave.open();
    this.#microwave.setTimer();
    this.#microwave.close();
    this.#chef.callWaiter();
    this.#waiter.serveCustomer();
    this.#chef.washDishes();
  }

  ngOnInit(): void {
    this.#loggerSubscription.subscribe((x: Message) => this.events.push(x))
  }

  ngOnDestroy(): void {
    this.#loggerSubscription.unsubscribe();
  }
}
