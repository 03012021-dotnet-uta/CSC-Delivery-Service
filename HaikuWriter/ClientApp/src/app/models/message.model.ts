export class Message {
    constructor(
        public messageid: number,
        public messageBody: string,
        public username: string | null,
        public threadId: number
    ) { }
}
