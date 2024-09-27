namespace exercise.webapi.AlternativeModels
{
    public class ABookDto
    {
        public string Title { get; set; }
        public List<PAuthorDto> Authors { get; set; }

        public PPublisherDto Publisher { get; set; }

    }
}
