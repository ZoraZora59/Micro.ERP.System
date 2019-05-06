using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MicroERP.Model;
using System.Web.Mvc;
using MicroERP.BLL;
using MicroERP.BLL.Models;
using MicroERP.BLL.App_Code;

namespace MicroERP.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserLoginForm model)
        {
            if (ModelState.IsValid)
            {
                string sessionValidCode = Session["validatecode"] == null ? string.Empty : Session["validatecode"].ToString();
                if (!model.Code.Equals(sessionValidCode))
                {
                    return RedirectToAction("Login", "Home", new { msg = "验证码错误！请重新输入" });
                }
                model.Password = md5tool.GetMD5(model.Password);
                UserManage userManage = new UserManage();
                ViewUserAsEmployee user = userManage.Login(model);
                if (user == null)
                {
                    return RedirectToAction("Login", "Home", new { msg = "账号或密码不正确，是否重新登陆？" });

                }
                else
                {
                    Session["loginuser"] = user;
                    return Redirect("/System/Main/Index/");
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult LogOut()
        {
            Session["loginuser"] = null;
            return Redirect("/");
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
        #region 验证码
        public FileResult ValidateCode()
        {
            ValidateCode vc = new ValidateCode();
            string code = vc.CreateValidateCode(4);
            Session["validatecode"] = code;//把数字保存在session中
            byte[] bytes = vc.CreateValidateGraphic(code);//根据数字转成二进制图片
            return File(bytes, @"image/jpeg");//返回一个图片jpg
        }
        #endregion
    }
}