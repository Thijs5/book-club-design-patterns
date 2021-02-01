import { LogService, Message } from "src/app/log.service";

export class Microwave {
    constructor(private logger: LogService) { }

    open() {
        this.log('opening microwave');
    }

    close() {
        this.log('closing microwave');
    }

    setTimer() {
        this.log('setting timer');
    }

    private log(message: string) {
        this.logger.log(new Message('microwave', message));
    }
}