using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
[ApiController]
public class Controller
{
    [Route("test")]
    [HttpGet]
    public ActionResult<List<Cats>> GetRess()
    {
        var res = new List<Cats>
        {
            new Cats { Name = "Tom", Age = 2, Id = 1, Color = "Black" },
            new Cats { Name = "Jerry", Age = 1, Id = 2, Color = "White" }
        };
        return res;
    }

    [Route("test/{id}")]
    [HttpGet]
    public ActionResult<Cats> GetRes(int id)
    {
        var res = new List<Cats>
        {
            new Cats { Name = "Tom", Age = 2, Id = 1, Color = "Black" },
            new Cats { Name = "Jerry", Age = 1, Id = 2, Color = "White" }
        };
        return res[id];
    }

}