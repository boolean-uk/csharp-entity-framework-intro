namespace exercise.webapi.Models
{
    public static class PublisherMapper
    {
            public static PublisherDTO MapToDTO(this Publisher publisher)
            {
                return new PublisherDTO
                {
                    Id = publisher.Id,
                    Name = publisher.Name,
                };
            }

            public static List<PublisherDTO> MapListToDTO(this List<Publisher> books)
            {
                return books.Select(publisher => new PublisherDTO
                {
                    Id = publisher.Id,
                    Name = publisher.Name,
                }).ToList();
            }
        }
    }

