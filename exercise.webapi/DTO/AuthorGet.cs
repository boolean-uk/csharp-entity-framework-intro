﻿using static exercise.webapi.DTO.BookDTO;

namespace exercise.webapi.DTO
{
    public class AuthorResponseDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<BookGet> Books { get; set; } = new List<BookGet>();
    }
}