import { HaikuLine } from './haiku-line.model';

describe('HaikuLine', () => {
  it('should create an instance', () => {
    expect(new HaikuLine(1, "Coffee is my life", "coffee silly", 5, true, "clarson217")).toBeTruthy();
  });
});
