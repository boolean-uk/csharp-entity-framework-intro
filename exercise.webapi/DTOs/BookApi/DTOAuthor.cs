namespace exercise.webapi.DTOs.BookApi
{
    public class DTOAuthor
    {

        public DTOAuthor(string fullname)
        {
            FullName = fullname;
        }
        public string FullName { get; set; }

    }
}
