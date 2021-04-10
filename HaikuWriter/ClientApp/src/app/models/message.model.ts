export class Message {
    constructor(
        public messageid: number,
        public messagebody: string,
        public username: string,
        public threadid: number
    ) { }
}
