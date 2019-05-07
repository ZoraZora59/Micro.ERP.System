using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MicroERP.BLL;
using MicroERP.BLL.App_Code;
using MicroERP.BLL.Models;
using MicroERP.Model;
using MicroERP.Web.Areas.System.Models;

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
            ViewBag.RegistMsg = Request.QueryString["RegistMsg"];
            ViewBag.UpdateMsg = Request.QueryString["UpdateMsg"];
            MainIndexViewModel model = new MainIndexViewModel();
            return View(model);
        }
        public JsonResult GetTableData()
        {
            string[] jsday = {"开发1日", "开发2日", "开发3日", "开发4日", "开发5日", "开发6日", "开发7日" };
            int[] jsnum= { 20000,10000,30000,25000,15000,37000,30000 };
            return Json(new TableViewModel { TDate = jsday,TNumbers=jsnum });
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