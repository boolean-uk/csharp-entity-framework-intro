﻿using System;
namespace exercise.webapi.DTO
{
	public class DTOAuthor
	{
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<DTOBook> books { get; set; }
    }
}