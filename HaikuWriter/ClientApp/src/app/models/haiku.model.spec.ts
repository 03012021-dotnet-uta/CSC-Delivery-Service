import { Haiku } from './haiku.model';

describe('Haiku', () => {
  it('should create an instance', () => {
    expect(new Haiku(5, "Coffee is my life", "I cannot live without it", "Sleep is for the weak", "coffee sleep no-sleep silly", true, "clarson217")).toBeTruthy();
  });
});
