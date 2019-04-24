using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MicroERP.BLL;
using MicroERP.BLL.App_Code;
using MicroERP.BLL.Models;

namespace MicroERP.Web.Areas.System.Controllers
{
    public class MainController : Controller  
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
                    return RedirectToAction("Login", "Main", new { msg = "验证码错误！请重新输入" });
                }
                UserManage userManage = new UserManage();
                UserLoginForm loginForm = userManage.Login(model);
                if (loginForm == null)
                {
                    return RedirectToAction("Login", "Main", new { msg = "账号或密码不正确，是否重新登陆？" });

                }
                else
                {
                    Session["loginuser"] = loginForm;
                    return Redirect("/system/main/index/");
                }
            }
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