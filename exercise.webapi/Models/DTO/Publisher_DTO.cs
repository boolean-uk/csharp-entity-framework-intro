namespace exercise.webapi.Models.DTO
{
    public class Publisher_DTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookDTO> Books { get; set; }
    }
}
