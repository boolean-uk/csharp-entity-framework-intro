using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class Payload<T> where T : class
    {
        public T Data {get;set;}
    }
}
