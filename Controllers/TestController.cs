using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

using AirBook.Options;
using AirBook.Models;
using System;

namespace AirBook.Controllers
{
    public class TestController : Controller
    {
        public readonly IOptions<TestOptions> _optionAccessor;
        private readonly TestContext _context;
        public TestController(TestContext context){
            _context = context;
        }

        [HttpGet]
        public IActionResult test(string version){

            var one = new TestModel();
            one.Name = "Tracy2";
            _context.test.Add(one);
            _context.SaveChanges();

            return new ObjectResult(one);
        }
    }
}