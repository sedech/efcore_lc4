namespace efcore_lc4.Entities
{
    public class Actor
    {
        public int ActorId { get; set; } 
        public string ActorName { get; set; } 
        public DateTime ActorBirthdate { get; set; }
        public string ActorPicture { get; set; }

        List<Movie> Movies { get; set;}

        public Actor(int actorId, string actorName, DateTime actorBirthdate, string actorPicture, List<Movie> movies)
        {
            ActorId = actorId;
            ActorName = actorName;
            ActorBirthdate = actorBirthdate;
            ActorPicture = actorPicture;
            Movies = movies;
        }
        
    }
}
