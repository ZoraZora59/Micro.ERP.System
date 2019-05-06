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
        protected override void OnActionExecuting(ActionExecutingContext filterContext)//获取用户登录信息
        {
            base.OnActionExecuting(filterContext);
            var currentLoginUser = Session["loginuser"] == null ? null : (ViewUserAsEmployee)Session["loginuser"];
            if (currentLoginUser == null)//如果没有登录，跳转到登录界面
            {
                filterContext.Result = Redirect("/Home/Login/");
            }
            else//如果是已离职员工，则跳转到主界面
            {
                if (currentLoginUser.UserStatus == "离职")
                {
                    filterContext.Result = RedirectToAction("Login", "Home", new { msg = "您已经办理离职，如有特殊情况请与人事部沟通。" });
                }
            }
            ViewBag.currentLoginInfo = currentLoginUser;
        }
        public ActionResult Index()
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
        
        public ActionResult ExitLog()//退出登录
        {
            Session["loginuser"] = null;
            return Redirect("/");
        }
    }
}