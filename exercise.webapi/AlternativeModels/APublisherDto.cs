namespace exercise.webapi.AlternativeModels
{
    public class APublisherDto
    {
        public string Name { get; set; }
        public string ContactDetails { get; set; }
        public List<PMBookDto> Books { get; set; }
    }
}
