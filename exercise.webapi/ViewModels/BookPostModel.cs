﻿using exercise.webapi.DtoModels;

namespace exercise.webapi.ViewModels
{
    public class BookPostModel
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
    }
}
