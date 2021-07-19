using HelloASPDotNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }


    
    public class HelloController : Controller
    {
        [Route("/welcome")]
        [HttpPost]
        [HttpGet]
        public IActionResult Index()
        {

            /* string textBox = "<input type='text' name='name' />";
             string button = "<input type='submit' value='Greet Me!' />";
             string select = "<select name='Language'>"+
                 "<option value ='english'>English</option>"+
                 "<option value ='spanish'>Spanish</option>"+
                 "</select>";

             string html = "<form method='post' action='/welcome/name'>"+textBox+select+button+"</form>";*/

            /*string textBox = "<input type='text' name='name' />";
            string button = "<input type='submit' value='Greet Me!' />";
            string select = "<select name='Language'>" +
                "<option value ='english'>English</option>" +
                "<option value ='spanish'>Spanish</option>" +
                "</select>";*/

            string html = "<form method='post' action='/welcome/name'>"+
                "<input type='text' name='name' />"+
                "<select name='language'><option value ='english' selected>English</option>"+"<option value ='spanish'>Spanish</option>" + "<option value ='french'>French</option>" + "<option value ='russian'>Russian</option>" + "<option value ='german'>German</option></select>" +
                "<input type='submit' value='Greet Me!' />"+
                "</form>";

            return Content(html, "text/html");


        }

        [Route("/welcome/name")]
        [HttpPost]
        public  IActionResult CreateMessage(string name, string language)
        {
            string html;

            if (language == "english")
            {
                html = "<h1>" + "Hello " + name + "<h1>";

                return Content(html, "text/html");
            }
            else if (language == "spanish")
            {
                html = "<h1>" + "Hola " + name + "<h1>";
                return Content(html, "text/html");

            }
            else if (language == "french")
            {
                html = "<h1>" + "Bonjour " + name + "<h1>";
                return Content(html, "text/html"); ;
            }
            else if (language == "russian")
            {
                html = "<h1>" + "Privet " + name + "<h1>";
                return Content(html, "text/html"); ;
            }
            else if (language == "german");
            {
                html = "<h1>" + "Hallo " + name + "<h1>";
                return Content(html, "text/html"); ;
            }

            html = "<h1>" + "Hello " + name + "<h1>";
            return Content(html, "text/html");




        }


        // GET: /<controller>/
       /* [HttpPost]
        public IActionResult Welcome(string name = "world!!")
        {
            string html = "<h1>" + "Hello " + name + "<h1>";
            return Content(html, "text/html");

        }*/




        /*public class GoodByeController : Controller
        {
            public IActionResult Index()
            {
                string html = "<form method='post' action='/helloworld/welcome'>" +
          "<input type='text' name='name' />" +
          "<input type='submit' value='Greet Me!' />" +
          "</form>";

                return Content(html, "text/html");
            }
        }*/
    }
}
