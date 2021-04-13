import { GenHaiku } from './gen-haiku.model';

describe('GenHaiku', () => {
  it('should create an instance', () => {
    expect(new GenHaiku("I cannot live without it", "Sleep is for the weak", "Sleep is for the weak", "tag1", "sagar1")).toBeTruthy();
  });
});
