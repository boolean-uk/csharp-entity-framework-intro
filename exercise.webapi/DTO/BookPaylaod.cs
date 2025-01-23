namespace exercise.webapi.DTO
{
    public class BookPaylaod<T> where T : class
    {
        public T Data { get; set; }

        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Email { get; set; }

        public string Message { get; set; } = "Status";
    }
}
