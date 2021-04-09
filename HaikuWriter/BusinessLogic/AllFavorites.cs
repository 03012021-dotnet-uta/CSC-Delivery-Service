namespace BusinessLogic
{
    public class AllFavorites
    {
        public User User { get; set; }
        public ICollection<UserFav> Favorites { get; set; }
        public AllFavorites(User user, ICollection<UserFav> favorites)
        {
            User = user;
            Favorites = new ICollection<UserFav>();
            for(int i = 0; i < favorites.Count; i++)
            {
                
            }
        }
    }
}