public class LoginService
{
    private List<User> _db;

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
}