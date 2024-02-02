namespace exercise.webapi.Models.DTO
{
    public class GetBookDtoNoAuthor
    {

        public int Id { get; set; }
        public string Title { get; set; }

        public PublisherForBookDto Publisher { get; set; }


    }
}
