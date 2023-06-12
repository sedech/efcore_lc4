namespace efcore_lc4.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string MovieGenre { get; set; }
        public int MovieDuration { get; set;}
        public decimal MovieBudget { get; set; }
    
    
        public List<Actor> Actors { get; set;}

        public Movie(int movieId, string movieName,  string movieGenre, int movieDuration, decimal movieBudget, List<Actor> actors)
        {
            MovieId = movieId;
            MovieName = movieName;
            MovieGenre = movieGenre;
            MovieDuration = movieDuration;
            MovieBudget = movieBudget;
            Actors = actors;

        }
    }

}

