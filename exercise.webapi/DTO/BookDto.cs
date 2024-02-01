﻿using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookDto

    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
    }
}
