//using exercise.webapi.Models;
//using exercise.webapi.Repository;
//using static System.Reflection.Metadata.BlobBuilder;

//namespace exercise.webapi.Endpoints
//{
//    public static class AuthorApi
//    {
//        public static void ConfigureAuthorApi(this WebApplication app)
//        {
//            app.MapGet("/authors", GetAll);
//            //app.MapGet("/authors/{id}", Get);
//        }

//        private static async Task<IResult> GetAll(IAuthorRepository authorRepository)
//        {
//            var authors = await authorRepository.Get();

//            List<AuthorDTO> authorDTOs = new List<AuthorDTO>();

//            foreach (var authorDTO in authors)
//            {
//                authorDTOs.Add(new AuthorDTO()
//                {
//                    Id = authorDTO.Id,
//                    FirstName = authorDTO.FirstName,
//                    LastName = authorDTO.LastName,
//                    Email = authorDTO.Email,
//                    Books = authorDTO.Books
//                });
//            }

//            return TypedResults.Ok(authors);
//        }

//        //private static async Task<IResult> Get(IAuthorRepository authorRepository, int id)
//        //{
//        //    var author = await authorRepository.Get(id);

//        //    if (author == null)
//        //        return Results.NotFound();
//        //    else
//        //        return TypedResults.Ok(author);
//        //}
//    }
//}
