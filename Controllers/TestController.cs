using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

using AirBook.Options;
using System;

namespace AirBook.Controllers
{
    public class TestController : Controller
    {
        public readonly IOptions<TestOptions> _optionAccessor;
        public TestController(IOptions<TestOptions> optionsAccessor){
            _optionAccessor = optionsAccessor;
        }

        [HttpGet]
        public IActionResult test(string version){
            throw new Exception("Exception triggered!");
            var obj = new Dictionary<string,string>();
            obj.Add("key","value");
            obj.Add("version",version);
            obj.Add("para", _optionAccessor.Value.Option1);
            return new ObjectResult(obj);
        }
    }
}