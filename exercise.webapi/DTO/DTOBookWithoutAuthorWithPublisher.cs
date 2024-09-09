namespace exercise.webapi.DTO
{
    public class DTOBookWithoutAuthorWithPublisher
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DTOPublisherWithoutBook Publisher { get; set; }
    }
}
