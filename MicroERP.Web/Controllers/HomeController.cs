using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MicroERP.Model;
using System.Web.Mvc;
using MicroERP.BLL;

namespace MicroERP.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}
		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
        public ActionResult SuccessfulCase()
        {
            return View();
        }
        public ActionResult Partner()
        {
            return View();
        }
        public ActionResult LetsDO()
        {
            return View();
        }
	}
}