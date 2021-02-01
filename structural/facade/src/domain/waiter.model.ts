import { LogService, Message } from "src/app/log.service";

export class Waiter {
    constructor(private logger: LogService) { }

    writeOrder() {
        this.log('writing down order');
    }
    
    sendToKitchen() {
        this.log('sending the order to the kitchen');
    }
    
    serveCustomer() {
        this.log('serving the customer');
    }

    private log(message: string) {
        this.logger.log(new Message('waiter', message));
    }
}
