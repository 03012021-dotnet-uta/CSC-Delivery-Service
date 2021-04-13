export class Haiku {
    constructor(
        public haikuId: number,
        public haikuLine1: string,
        public haikuLine2: string,
        public haikuLine3: string,
        public tags: string,
        public approved: boolean,
        public username: string
    ){}
}
