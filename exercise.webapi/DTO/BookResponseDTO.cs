﻿using exercise.webapi.DTO;
using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class BookResponseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int PublisherId { get; set; }
        public PublisherDTO Publisher { get; set; }

        public ICollection<AuthorDTO> Authors { get; set; } = new List<AuthorDTO>();
    }
}
