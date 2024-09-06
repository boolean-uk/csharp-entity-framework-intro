namespace exercise.webapi.Models
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public AuthorDTO(int id, string firstname, string lastname, string email)
        {
            this.Id = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
        }
    }
}
