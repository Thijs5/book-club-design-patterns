import { Injectable } from "@angular/core";
import { Subject } from "rxjs";

@Injectable()
export class LogService {
    message = new Subject<Message>()
    
    log(message: Message) {
        this.message.next(message);
        console.log(message.toString());
    }
}

export class Message {
    constructor(
        readonly source: string,
        readonly message: string
    ) { }

    toString() {
        return `${this.source} - ${this.message}`;
    }
}