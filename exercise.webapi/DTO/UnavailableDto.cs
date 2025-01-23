using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class UnavailableDto
    {
        public BookDto Book { get; set; }
        public DateTime AvailableBy { get; set; }
        
    }
}
