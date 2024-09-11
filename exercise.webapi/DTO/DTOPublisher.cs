namespace exercise.webapi.DTO
{
    public class DTOPublisher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<DTOBookWithoutPublisher> published {  get; set; } = new List<DTOBookWithoutPublisher>();
    }
}
