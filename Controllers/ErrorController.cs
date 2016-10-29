using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

using AirBook.Options;
using Microsoft.AspNetCore.Builder;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace AirBook.Controllers
{
    public class ErrorController : Controller
    {

        //In the tutorial, this can be public static void HomePage(IApplicationBuilder app)
        //But failed when i tried
        [HttpGet]
        public IActionResult Index(string version){
            var obj = new Dictionary<string,string>();
            obj.Add("key","value");
            obj.Add("version",version);
            return new ObjectResult(obj);
        }
    }
}