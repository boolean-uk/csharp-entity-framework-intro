﻿namespace exercise.webapi.DTO
{
    public class DTOBook
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DTOAuthor Author { get; set; }
    }
}
