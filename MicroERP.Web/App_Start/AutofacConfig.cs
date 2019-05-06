using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration;
using Autofac.Integration.Mvc;

namespace MicroERP.Web.App_Start
{
    public class AutofacConfig
    {
        public static void Register()
        {
            //构造一个Autofac的Builder容器
            var builder = new ContainerBuilder();
            #region 注册程序集
            //注册程序集，有接口的可以用接口来保存
            Assembly controllerAss = Assembly.Load("MicroERP.Web");
            builder.RegisterControllers(controllerAss);
            builder.RegisterFilterProvider();
            Assembly dal = Assembly.Load("MicroERP.DAL");
            Type[] dalTypes = dal.GetTypes();
            builder.RegisterTypes(dalTypes).AsImplementedInterfaces();
            Assembly bll = Assembly.Load("MicroERP.BLL");
            builder.RegisterTypes(bll.GetTypes());
            #endregion
            //创造Autofac工作容器的实例
            var container = builder.Build();
            //替换MVC默认的控制器工厂
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}