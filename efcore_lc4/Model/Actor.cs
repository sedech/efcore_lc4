namespace efcore_lc4.Model
{
    public class Actor
    {
        public int Id { get; set; }
        public string ActorName { get; set; }
        public DateTime ActorBirthdate { get; set; }
        public string ActorPicture { get; set; }

        public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}
