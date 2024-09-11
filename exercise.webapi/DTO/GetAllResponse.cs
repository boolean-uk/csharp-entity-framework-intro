namespace exercise.webapi.DTO
{
    public class GetAllResponse<T>
    {
        public List<T> response { get; set; } = new List<T>();
    }
}
