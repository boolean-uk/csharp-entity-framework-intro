namespace exercise.webapi.Models.DataTransfer
{
    public class Payload<T>(T Data) where T : class
    {
        public string status { get; set; } = "success";

        public DateTime created { get; set; } = DateTime.Now;
        public T Data { get; set; } = Data;
    }
}
