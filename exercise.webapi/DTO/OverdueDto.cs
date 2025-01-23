namespace exercise.webapi.DTO
{
    public class OverdueDto
    {
        public BookDto Book { get; set; }
        public DateTime DueDate { get; set; }
        public int DaysOverdue { get; set; }
    }
}
