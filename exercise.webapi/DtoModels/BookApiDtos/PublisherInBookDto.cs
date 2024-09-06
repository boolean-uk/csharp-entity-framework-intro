namespace exercise.webapi.DtoModels.BookApiDtos
{
    public class PublisherInBookDto
    {
        public string Name { get; set; }

        public PublisherInBookDto(string name)
        {
            Name = name;
        }
    }
}
