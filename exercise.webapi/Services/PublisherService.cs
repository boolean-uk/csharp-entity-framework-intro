using System.Reflection.Emit;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Services
{
    public class PublisherService
    {
        private readonly IPublisherRepository _publisherRepository;

        public PublisherService(IPublisherRepository repository)
        {
            _publisherRepository = repository;
        }

        public async Task<List<GetPublisherDTO>> GetPublishers()
        {
            var publishers = await _publisherRepository.GetPublishers();
            List<GetPublisherDTO> publishersDTO = new List<GetPublisherDTO>();

            foreach (var publisher in publishers)
            {
                GetPublisherDTO publisherDTO = ConvertToGetPublisherDTO(publisher);
                publishersDTO.Add(publisherDTO);
            }

            return publishersDTO;
        }

        public async Task<GetPublisherDTO> GetPublisher(int id)
        {
            Publisher publisher = await _publisherRepository.GetPublisher(id);

            GetPublisherDTO publisherDTO = ConvertToGetPublisherDTO(publisher);

            return publisherDTO;
        }


        private GetPublisherDTO ConvertToGetPublisherDTO(Publisher publisher)
        {

            var authorDTO = new GetPublisherDTO
            {
                Id = publisher.Id,
                Name = publisher.Name,
                Books = publisher.Books.Select(b => new GetPublisherBookDTO
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = new AuthorDTO
                    {
                        Id = b.Author.Id,
                        FirstName = b.Author.FirstName,
                        LastName = b.Author.LastName,
                        Email = b.Author.Email
                    }
                }).ToList()
            };

            return authorDTO;
        }
    }
}
