namespace exercise.webapi.Repository
{
    public interface IBookAuthorRepository
    {
        public Task<int> RemoveAuthorFromBookById(int bookId, int authorId);
        public Task<int> AddAuthorToBook(int bookId, int authorId);
    }
}
