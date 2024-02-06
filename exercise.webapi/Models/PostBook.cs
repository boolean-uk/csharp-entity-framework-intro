using System.Diagnostics.CodeAnalysis;

namespace exercise.webapi.Models
{
    public class PostBook
    {
        [NotNull]
        public string Title { get; set; }

        public int[] AuthorIds {  get; set; }

        public int PublisherId { get; set; }
    }
}
