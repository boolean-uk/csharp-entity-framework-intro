using exercise.webapi.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.AlternativeModels
{
    public class PostBook
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
    }
}
