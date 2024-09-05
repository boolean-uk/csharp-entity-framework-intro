using exercise.webapi.Models;
using System.Reflection.Metadata.Ecma335;

namespace exercise.webapi.DTO
{
    public class BookGetModel
    {
        public string Title { get; set; }
        public BookAuthorModel Author { get; set; }
        public string Publisher { get; set; }
    }
}
