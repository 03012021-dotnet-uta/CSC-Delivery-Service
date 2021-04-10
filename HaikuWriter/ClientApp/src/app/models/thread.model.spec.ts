import { Thread } from './thread.model';

describe('Thread', () => {
  it('should create an instance', () => {
    expect(new Thread(1, "Test Thread", "clarson217")).toBeTruthy();
  });
});
