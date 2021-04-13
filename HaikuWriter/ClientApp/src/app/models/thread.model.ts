import { User } from "./user.model";

export class Thread {
    constructor(
        public threadid:  number,
        public description: string,
        public username: string | null,
        //public user: User,
    ) { }
}
