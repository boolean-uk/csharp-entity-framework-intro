﻿namespace exercise.webapi.DTO
{
    public class AuthorPostModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public List<int> BookIds { get; set; } = new List<int>();
    }
}
