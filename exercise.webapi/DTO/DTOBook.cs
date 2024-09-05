using System;
namespace exercise.webapi.DTO
{
	public class DTOBook
	{
		public int Id { get; set; }
		public string Title { get; set; }
		
		public int AuthorID { get; set; }

		public string authorName { get; set; }
	}
}

