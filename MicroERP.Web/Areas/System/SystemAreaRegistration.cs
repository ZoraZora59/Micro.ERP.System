using System.Web.Mvc;

namespace MicroERP.Web.Areas.System
{
    public class SystemAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "System";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "System_default",
                "System/{controller}/{action}/{id}",
                new {Controller="Main", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}