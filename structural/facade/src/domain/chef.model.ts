import { LogService, Message } from "src/app/log.service";

export class Chef {
    constructor(private logger: LogService) { }

    receiveOrder() {
        this.log('reading order');
    }

    callWaiter() {
        this.log('calling waiter');
    }

    serveCustomer() {
        this.log('serving customer');
    }

    washDishes() {
        this.log('washing dishes');
    }

    private log(message: string) {
        this.logger.log(new Message('chef', message));
    }
}