using System.Net;
using System.Text.Json.Serialization;

namespace exercise.webapi.Models
{
    public class Response<T> where T : class
    {
        [JsonPropertyName("status")]
        public HttpStatusCode Status { get; set; }
        public T item { get; set; }

    }
}
