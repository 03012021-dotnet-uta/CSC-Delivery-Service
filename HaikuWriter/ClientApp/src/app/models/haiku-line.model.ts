export class HaikuLine {
    constructor(
        public haikuLineId: number,
        public line: string,
        public tags: string,
        public syllable: number,
        public approved: boolean,
        public username: string
    ){}
}
