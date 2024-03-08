using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class PublisherRepository: IPublisherRepository
    {
        DataContext _db;
        
        public PublisherRepository(DataContext db)
        {
            _db = db;
        }


       
        public async Task<IEnumerable<PublisherResponseDTO>> GetAllPublishers()
        {
            
            var publishers = await _db.Publishers.Include(p => p.Books).ToListAsync();
            
            List<PublisherResponseDTO> result = new List<PublisherResponseDTO>();
            foreach (var publisher in publishers)
            {
                var dto = await PutPublisherInDTO(publisher);
                result.Add(dto);
            }
            _db.SaveChanges();
            return result;
        }

        public async Task<PublisherResponseDTO> GetPublisher(int id)
        {
            
            var publisher = await _db.Publishers.Include(p => p.Books).SingleOrDefaultAsync(p => p.Id == id);
            PublisherResponseDTO publisherResponseDTO = await PutPublisherInDTO(publisher);
            _db.SaveChanges();
            return publisherResponseDTO;
        }
       

        private async Task<PublisherResponseDTO> PutPublisherInDTO(Publisher? publisher)
        {
            var authors = await _db.Authors.ToListAsync();  // added authors here. might become usefull bellow
            PublisherResponseDTO responseDTO = new PublisherResponseDTO();
            if(publisher != null)
            {
                responseDTO.Id = publisher.Id;
                responseDTO.Name = publisher.name;

                List<P_BookDTO> list = new List<P_BookDTO>();

                foreach(var book in publisher.Books)
                {
                    P_BookDTO bookDTO = new P_BookDTO();
                    bookDTO.Id = book.Id;
                    bookDTO.Title = book.Title;
                    bookDTO.authorID = book.AuthorId;
                    // book.Author is null at this point. need to somehow get acces to the Author of the book.
                    Author? author = authors.Find(a => a.Id == bookDTO.authorID);
                    if (author != null)
                    {
                        bookDTO.Author.Id = author.Id;
                        bookDTO.Author.FirstName = author.FirstName;
                        bookDTO.Author.LastName = author.LastName;
                        bookDTO.Author.Email = author.Email;
                    }
                    
                   
                    responseDTO.Books.Add(bookDTO);
                }

                

                return responseDTO;
            }
            else
            {
                throw new Exception("Author was null");
            }

            
        }
       
       

    }
}
