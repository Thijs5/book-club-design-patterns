import { LogService } from "src/app/log.service";
import { Chef } from "./chef.model";
import { Microwave } from "./microwave.model";

export class Kitchen {
    #chef: Chef;
    #microwave: Microwave;

    constructor(logger: LogService) {
        this.#chef = new Chef(logger);
        this.#microwave = new Microwave(logger);
    }

    processOrder() {
        this.#chef.receiveOrder();
        this.#microwave.open();
        this.#microwave.setTimer();
        this.#microwave.close();
        this.#chef.callWaiter();
    }

    washDishes() {
        this.#chef.washDishes();
    }
}