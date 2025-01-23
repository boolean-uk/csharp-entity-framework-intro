﻿using System.Text.Json.Serialization;

namespace exercise.webapi.DTO
{
    public class AuthorGetDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<BookGetDTO>? Books { get; set; }
        public List<PublisherGetDTO>? Publishers { get; set; }
    }
}
