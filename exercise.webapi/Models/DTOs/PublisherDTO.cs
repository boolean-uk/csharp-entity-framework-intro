
namespace exercise.webapi.Models.DTOs {

    public class PublisherDTO {
        public int Id {get; set;}
        public string Company {get; set;}

        public PublisherDTO(Publisher publisher) {
            Id = publisher.Id;
            Company = publisher.Company;
        }
        public static List<PublisherDTO> FromRepository(IEnumerable<Publisher> publishers) {
            var results = new List<PublisherDTO>();
            foreach (var publisher in publishers) {
                results.Add(new PublisherDTO(publisher));
            }
            return results;
        }


    }
}