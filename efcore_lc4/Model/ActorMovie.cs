namespace efcore_lc4.Model
{
    public class ActorMovie
    {
        public int ActorId { get; set; }
        public Actor? Actor { get; set; }

        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
    }
}

