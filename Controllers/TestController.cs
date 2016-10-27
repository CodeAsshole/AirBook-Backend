using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AirBook.Controllers
{
    public class TestController : Controller
    {
        public TestController(){

        }

        [HttpGet]
        public IActionResult test(string version, string para){
            var obj = new Dictionary<string,string>();
            obj.Add("key","value");
            obj.Add("version",version);
            obj.Add("para",para);
            return new ObjectResult(obj);
        }
    }
}