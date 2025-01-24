using exercise.webapi.Models;

namespace exercise.webapi.ViewModels
{
    public class BookPost
    {

        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
    }
}
