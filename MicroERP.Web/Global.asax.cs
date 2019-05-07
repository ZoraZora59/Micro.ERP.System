using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MicroERP.DAL;
using MicroERP.Web.App_Start;

namespace MicroERP.Web
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
            AutofacConfig.Register();//AutoFac注入
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
            //清理视图引擎，只保留Razor
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());

            #region 数据库初始化
            //自动建立数据库
            using (var Context = new MicroERPContext())
            {
                try
                {
                    Context.Database.CreateIfNotExists();
                    Context.UserSelves.Add(new Model.InfoUserSelf
                    {
                        UserName = "左拉",
                        UserPassword = "922729261802228716010917272521672032050",
                        UserStatus = "在职",
                        UserSalary = 3000,
                        UserPhoneNumber = "12345678901",
                        UserDepartment = "综合管理部",
                        UserPosition = "总监",
                        UserEmail = "123123123@pp.com",
                        UserAddress = "湖南省株洲市天元区泰山路湖南工业大学",
                        OfferDate = DateTime.Now
                    });
                    Context.SaveChanges();
                }
                catch (Exception)
                {
                }
            }
            #endregion
        }
	}
}
