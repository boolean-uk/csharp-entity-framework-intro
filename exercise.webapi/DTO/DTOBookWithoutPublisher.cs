namespace exercise.webapi.DTO
{
    public class DTOBookWithoutPublisher
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DTOAuthorWithoutBooks Author { get; set; }
    }
}
