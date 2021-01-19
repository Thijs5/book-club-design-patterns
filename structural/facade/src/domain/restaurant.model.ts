import { LogService } from "src/app/log.service";
import { Kitchen } from "./kitchen.model";
import { Waiter } from "./waiter.model";

export class Restaurant {
    #kitchen: Kitchen;
    #waiter: Waiter;
    
    constructor(logger: LogService) {
        this.#kitchen = new Kitchen(logger);
        this.#waiter = new Waiter(logger);
    }

    order() {
        this.#waiter.writeOrder();
        this.#waiter.sendToKitchen();
        this.#kitchen.processOrder();
        this.#waiter.serveCustomer();
        this.#kitchen.washDishes();
    }
}