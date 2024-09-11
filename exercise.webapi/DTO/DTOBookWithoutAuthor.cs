namespace exercise.webapi.DTO
{
    public class DTOBookWithoutAuthor
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public DTOPublisherWithoutBooks Publisher { get; set; }
    }
}
