﻿using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublisherId {get; set;}
        public Publisher Publisher {get; set;} = null!;
        public ICollection<BookAuthor> BookAuthors { get; set; } = [];
    }
}
