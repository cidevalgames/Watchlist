namespace Watchlist.Data
{
    public class MyUser : Microsoft.AspNetCore.Identity.IdentityUser
    {
        public MyUser() : base()
        {
            this.MoviesList = new HashSet<UserMovie>();
        }

        public string FirstName { get; set; }
        public virtual ICollection<UserMovie> MoviesList { get; set; }
    }
}
