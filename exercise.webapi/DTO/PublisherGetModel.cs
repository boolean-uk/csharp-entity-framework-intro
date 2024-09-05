namespace exercise.webapi.DTO
{
    public class PublisherGetModel
    {
        public string Name { get; set; }
        public ICollection<PublisherBookModel> Books { get; set; } = new List<PublisherBookModel>();
    }
}
