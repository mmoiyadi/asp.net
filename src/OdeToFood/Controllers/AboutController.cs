using Microsoft.AspNetCore.Mvc;


namespace OdeToFood.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        //[Route("[action]")]
        public string Phone()
        {
            return "91-9881902256";
        }

        //[Route("[action]")]
        public string Address()
        {
            return "Pune, India";
        }
    }
}
