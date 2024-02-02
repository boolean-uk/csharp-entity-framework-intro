namespace exercise.webapi.AlternativeModels
{
    public class AAuthorDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<AMBookDto> Books { get; set; }
    }
}
