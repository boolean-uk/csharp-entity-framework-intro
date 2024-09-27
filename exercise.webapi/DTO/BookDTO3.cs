using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookDTO3
    {
        // THIS IS USE TO AVOID CYCLIC REFERENCE: NO AUTHOR HERE! IF AUTHOR IS HERE --> WE WILL GET CYCLIC REFERENCE
        public int Id { get; set; }
        public string Title { get; set; }

        public Author Author { get; set; }
    }
}
