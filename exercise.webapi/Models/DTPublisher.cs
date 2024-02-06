namespace exercise.webapi.Models
{
    public class DTPublisher
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int BookCounter { get; set; }

        public ICollection<SimpleBook> Books { get; set; }
    }
}
