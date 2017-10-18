using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAppTest.Controllers
{
    public class HelloWorldController : Controller
    {

        [Route("sayhello/{id}")]
        public string SayHello(string name, int id = 1)
        {
            return $"Hello {name}, you have an ID of: {id}";
        }


        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AnotherPage()
        {
            return RedirectToAction("Index");
        }
    }
}