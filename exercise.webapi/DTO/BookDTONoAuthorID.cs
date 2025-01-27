namespace exercise.webapi.DTO
{
    public class BookDTONoAuthorID
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public AuthorDTONoId author { get; set; }
    }
}
