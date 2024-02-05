using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace exercise.webapi.Models.DatabaseModels
{
    public class Publisher
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [JsonIgnore]
        public IEnumerable<Book> Books { get; set; }

        [JsonIgnore]
        public IEnumerable<Author> Authors { get; set; }


    }
}
