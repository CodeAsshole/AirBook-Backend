using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AirBook.Controllers
{
    public class TestController : Controller
    {
        public TestController(){

        }

        [HttpGet]
        public IActionResult test(string version){
            var obj = new Dictionary<string,string>();
            obj.Add("key","value");
            obj.Add("version",version);
            return new ObjectResult(obj);
        }
    }
}