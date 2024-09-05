﻿using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class ResponseBookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public AuthorDTO Author { get; set; }
       

        public ResponseBookDTO()
        {
            Author = new AuthorDTO();
        }

    }
}
