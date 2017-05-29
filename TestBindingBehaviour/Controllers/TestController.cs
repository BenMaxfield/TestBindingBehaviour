using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestBindingBehaviour.Models;

namespace TestBindingBehaviour.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index(string username)
        {
            string name = null;
            string bio = null;

            if (string.IsNullOrWhiteSpace(username))
            {
                name = "Not set";
                bio = "No Username Passed";
            }
            else
            {
                name = "username";
                bio = "Username was Passed";

            }
            var model = new TestModel()
            {
                Bio = bio,
                Username = name
            };
            return View(model);
        }
    }
}