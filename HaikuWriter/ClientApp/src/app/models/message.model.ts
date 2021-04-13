export class Message {
    constructor(
        public messageid: number,
        public messagebody: string,
        public username: string | null,
        public threadid: number
    ) { }
}
