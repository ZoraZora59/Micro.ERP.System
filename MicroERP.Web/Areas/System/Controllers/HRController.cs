﻿using MicroERP.BLL;
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
        private UserManage userManage;
        public HRController(UserManage manage)
        {
            userManage = manage;
        }
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
        [HttpGet]
        public ActionResult CreateEmployee()
        {
            ViewBag.selListDep = DepartmentDropDownList().AsEnumerable();
            ViewBag.selListPos = PositionDropDownList().AsEnumerable();
            return View();
        }
        [HttpPost]
        public ActionResult CreateEmployee(InfoUserSelf userSelf)
        {
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