namespace exercise.wwwapi.Helpers
{
    public class IdGenerator
    {
        private int _bookId = 251;

        public int GetBookId()
        {
            return _bookId++;
        }
    }
}