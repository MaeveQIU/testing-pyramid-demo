using Microsoft.AspNetCore.Mvc;

namespace TestingPyramid.Controllers
{
    [ApiController]
    [Route("/individuals")]
    public class IndividualController : ControllerBase
    {
        
        [HttpGet(Name = "GetIndividual")]
        public string Get()
        {
            return "Hello World!";
        }
    }
}