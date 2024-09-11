﻿namespace exercise.webapi.DTO
{
    public class DTOAuthor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<DTOBookWithoutAuthor> books { get; set; } = new List<DTOBookWithoutAuthor>();
    }
}
