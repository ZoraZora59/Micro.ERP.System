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
        [HttpGet]
		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
        [HttpPost]
        public ActionResult Contact(InfoUserSelf model)
        {
            UserManage userManage = new UserManage();
            userManage.CreateNewEmployee(model);
            return View();
        }
        //public ActionResult ViewList()
        //{
        //    UserManage userManage = new UserManage();
        //    var model=userManage.GetList();
        //    return View(model);
        //}
	}
}