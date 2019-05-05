using MicroERP.BLL;
using MicroERP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MicroERP.Web.Areas.System.Controllers
{
    public class HRController : Controller
    {
        public bool GetSessionInfo()//将Session中的登录信息获取到ViewBag的currentLoginInfo
        {
            var currentLoginUser = (ViewUserAsEmployee)Session["loginuser"];
            if (currentLoginUser == null)
                return false;
            ViewBag.currentLoginInfo = currentLoginUser;
            return true;
        }

        [HttpGet]
        public ActionResult CreateEmployee()
        {
            GetSessionInfo();
            ViewBag.selListDep = DepartmentDropDownList().AsEnumerable();
            ViewBag.selListPos = PositionDropDownList().AsEnumerable();
            return View();
        }
        [HttpPost]
        public ActionResult CreateEmployee(InfoUserSelf userSelf)
        {
            UserManage userManage = new UserManage();
            userManage.CreateNewEmployee(userSelf);
            return RedirectToAction("Index", "Main", new { msg = "新员工注册完毕" });
        }

        public ActionResult UpdateEmployee()
        {
            return View();
        }
        public ActionResult UpdateViolation()
        {
            return View();
        }
        public ActionResult Index()
        {
            GetSessionInfo();
            UserManage userManage = new UserManage();
            return View(userManage.GetUserAsEmployees());
        }
        public ActionResult ViolationIndex()
        {
            return View();
        }
        #region 获取下拉表单数据
        public SelectList PositionDropDownList()
        {
            UserManage userManage = new UserManage();
            return new SelectList(userManage.GetPositionList());
        }
        public SelectList DepartmentDropDownList()
        {
            UserManage userManage = new UserManage();
            return new SelectList(userManage.GetDepartmentList());
        }
        #endregion
    }
}