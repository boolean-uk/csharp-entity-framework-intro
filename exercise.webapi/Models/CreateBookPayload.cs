using System.ComponentModel.DataAnnotations;

namespace exercise.webapi.Models
{
    public record CreateBookPayload([Required] string Title, [Required]Author author );
}
