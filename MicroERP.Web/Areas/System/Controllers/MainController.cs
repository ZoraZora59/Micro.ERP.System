using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MicroERP.BLL;
using MicroERP.BLL.App_Code;
using MicroERP.BLL.Models;
using MicroERP.Model;

namespace MicroERP.Web.Areas.System.Controllers
{
    public class MainController : Controller  
    {
        public ActionResult Index()
        {
            if (GetSessionInfo())
                return View();
            else
                return Redirect("/System/Main/Login");
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        public bool GetSessionInfo()//将Session中的登录信息获取到ViewBag的currentLoginInfo
        {
            var currentLoginUser = (ViewUserAsEmployee)Session["loginuser"];
            if (currentLoginUser == null)
                return false;
            ViewBag.currentLoginInfo = currentLoginUser;
            return true;
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
                ViewUserAsEmployee user = userManage.Login(model);
                if (user == null)
                {
                    return RedirectToAction("Login", "Main", new { msg = "账号或密码不正确，是否重新登陆？" });

                }
                else
                {
                    Session["loginuser"] = user;
                    return Redirect("/system/main/index/");
                }
            }
            return View();
        }
        public ActionResult ExitLog()//退出登录
        {
            Session["loginuser"] = null;
            return Redirect("/");
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