import { User } from './user.model';

describe('User', () => {
  it('should create an instance', () => {
    expect(new User("clarson217", "chris", "larson", "I<3haikus", "clarson217@gmail.com", "Ilovehaikus", "@IloveHaikus", true)).toBeTruthy();
  });
});
