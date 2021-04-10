export class Haiku {
    constructor(
        public haikuid: number,
        public haikuline1: string,
        public haikuline2: string,
        public haikuline3: string,
        public tags: string,
        public approved: boolean,
        public username: string
    ){}
}
