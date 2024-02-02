namespace exercise.webapi.Models
{

    public enum Status { NotFound, Ok, BadRequest }

    public class Payload<T> where T : class
    {

        public Status status { get; set; } = Status.Ok;

        public T data { get; set; }

    }
}
