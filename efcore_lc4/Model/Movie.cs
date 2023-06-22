namespace efcore_lc4.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string MovieGenre { get; set; }
        public int MovieDuration { get; set; }
        public float MovieBudget { get; set; }

        public virtual ICollection<Actor> Actors { get; set;} = new List<Actor>();

    }
}
