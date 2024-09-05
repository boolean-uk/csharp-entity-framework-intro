namespace exercise.webapi.Models.ModelsBookAPI
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<AuthorDto> Authors { get; set; }
    }
}
