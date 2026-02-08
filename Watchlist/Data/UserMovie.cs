namespace Watchlist.Data
{
    public class UserMovie
    {
        public string UserID { get; set; }
        public int MovieID { get; set; }
        public bool Watched { get; set; }
        public int Rating { get; set; }
        public virtual MyUser User { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
