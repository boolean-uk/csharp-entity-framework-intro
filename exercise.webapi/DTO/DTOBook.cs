using exercise.webapi.Models;
using System;
namespace exercise.webapi.DTO
{
	public class DTOBook
	{
		public int Id { get; set; }
		public string Title { get; set; }
		
		public int AuthorID { get; set; }

		public string authorName { get; set; }

		public static List<DTOBook> getDTOBooks(List<Book> books)
		{
			List<DTOBook> dTOBooks = new List<DTOBook>();
			foreach (Book book in books)
			{
				dTOBooks.Add(new DTOBook
				{
					Id = book.Id,
					Title = book.Title,
					AuthorID = book.AuthorId,
					authorName = $"{book.Author.FirstName} {book.Author.LastName}"
				});
			}

			return dTOBooks;
		}
	}

}

