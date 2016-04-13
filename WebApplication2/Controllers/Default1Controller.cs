using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class Default1Controller : Controller
    {
        //
        // GET: /Default1/
        // added new controller to master
        public ActionResult Index()
        {
            return View();
        }

        private void test()
        {
            // no code
        }
	}
}