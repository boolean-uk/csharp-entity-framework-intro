namespace exercise.webapi.Models.DataTransfer.Publisher
{
    public class PublisherDTO
    {
        public PublisherDTO(BaseModels.Publisher publisher)
        {
            this.ID = publisher.ID;
            this.Name = publisher.Name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}
