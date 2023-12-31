public class LoginService
{
    private readonly List<User> _db;

    public LoginService()
    {
        // init a fake db 
        _db = new List<User>
        {
            // add some dummy data
            new() { Username = "test", Password = "test", Channel = "test" },
            new() { Username = "test2", Password = "test2", Channel = "test2" }
        };
    }
    public bool Login(LoginRequest request)
    {
        // check if user exists in db
        var user = _db.FirstOrDefault(x => x.Username == request.Username && x.Password == request.Password);
        // if user exists, and matches the request's  channel, return true
        if (user != null && user.Channel == request.Channel)
        {
            return true;
        }
        // otherwise, return false
        return false;

    }

    public LoginResponse<SuccessData> GetSuccessResponse()
    {
        // return a success response
        return new LoginResponse<SuccessData>
        {
            Code = 200,
            Message = "ok",
            Data = new SuccessData
            {
                Reauth = true,
                Username = "test",
                Balance = "test",
                Duration = "test",
                Outport = "test",
                Totaltimespan = "test",
                Usripadd = "test"
            }
        };
    }

    public LoginResponse<ErrorData> GetErrorResponse()
    {
        // return an error response
        return new LoginResponse<ErrorData>
        {
            Code = 201,
            Message = "ok",
            Data = new ErrorData
            {
                Text = "Invalid username or password"
            }
        };
    }
}