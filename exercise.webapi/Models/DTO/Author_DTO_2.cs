﻿namespace exercise.webapi.Models.DTO
{
    public class Author_DTO_2
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<Book_DTO_2> Books { get; set; }
    }
}
