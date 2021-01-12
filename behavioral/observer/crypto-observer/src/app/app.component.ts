import { Component, OnInit } from '@angular/core';
import { interval } from 'rxjs';
import { BitCoin } from './models/crypto-currencies/bitcoin';
import { Person } from './models/observers/person';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.sass']
})
export class AppComponent implements OnInit {
  bitcoin: BitCoin;
  persons: Person[] = [];

  ngOnInit(): void {
    this.bitcoin = new BitCoin(10);
    const frank = new Person('Frank');
    this.bitcoin.attach(frank);
    const john = new Person('John');
    this.bitcoin.attach(john);
    const charlie = new Person('Charlie');
    this.bitcoin.attach(charlie);

    this.persons.push(frank);
    this.persons.push(john);
    this.persons.push(charlie);

    interval(2000)
      .subscribe({
        next: () => this.bitcoin.price = Math.floor(Math.random() * 100)
      });
  }
}
