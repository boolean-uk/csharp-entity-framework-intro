namespace exercise.webapi.Models.DTO
{
    public class GetPublisherDto
    {

        public int Id { get; set; }
        public string Name {  get; set; }
        public ICollection<BookDto2> Books { get; set; } = new List<BookDto2>();

    }
}
