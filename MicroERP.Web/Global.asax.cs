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
            ////自动建立数据库
            //using (var Context = new MicroERPContext())
            //{
            //    Context.Database.CreateIfNotExists();
            //}
        }
	}
}
