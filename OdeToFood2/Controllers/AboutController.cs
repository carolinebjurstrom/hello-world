using Microsoft.AspNetCore.Mvc;

namespace OdeToFood2.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {

        public string Phone()
        {
            return "+1-555-555-555";
        }

        public string Country()
        {
            return "USA";
        }
    }
}
