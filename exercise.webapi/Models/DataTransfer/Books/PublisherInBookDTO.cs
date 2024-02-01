namespace exercise.webapi.Models.DataTransfer.Books
{
    public class PublisherInBookDTO(int Id, string Name)
    {
        public int Id { get; set; } = Id;

        public string Name { get; set; } = Name;
    }
}