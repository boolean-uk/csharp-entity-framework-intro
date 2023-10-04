using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ef.intro.wwwapi.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }        
    }
}