using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  public class HelloController : ControllerBase
  {
    [Route("oi")]
    public Hello Hello()
    {
      Hello OkResult = new Hello { message = "oi mundo" };

      return OkResult;
    }
  }
}