using System;

namespace exercise.webapi.Payload;

public class Payload<T> where T : class
{
    public T Data;
    public bool GoodResponse = true;
    public string Message = "Success";

}
