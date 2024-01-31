using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace exercise.webapi.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<AuthorBook> AuthorBooks { get; set; } = new List<AuthorBook>();

    }
}