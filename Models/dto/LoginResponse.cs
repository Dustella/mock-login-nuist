public class LoginResponse<T>
{
    public required int Code { get; set; }
    public required string Message { get; set; }
    public T? Data { get; set; }
}

public class SuccessData
{
    public required bool Reauth { get; set; }
    public required string Username { get; set; }
    public required string Balance { get; set; }
    public required string Duration { get; set; }
    public required string Outport { get; set; }
    public required string Totaltimespan { get; set; }
    public required string Usripadd { get; set; }
}

public class ErrorData
{
    public required string Text { get; set; }
}