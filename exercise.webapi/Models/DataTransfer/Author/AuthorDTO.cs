using exercise.webapi.Models.BaseModels;

namespace exercise.webapi.Models.DataTransfer.Author
{
    public class AuthorDTO
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public AuthorDTO(BaseModels.Author author)
        {
            ID = author.ID;
            FirstName = author.FirstName;
            LastName = author.LastName;
            Email = author.Email;
        }
    }
}
