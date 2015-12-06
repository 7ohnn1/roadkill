using System.Web.Http;
using System.Web.Mvc;

namespace Roadkill.Core.Mvc.Controllers
{
	public class SiteSettingsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
				return "SiteSettings";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
			// "/SiteSettings/{controller}/{action}/{id}"
			context.MapRoute(
				"SiteSettings_Controller",
				"SiteSettings/{controller}/{action}/{id}",
				new { controller = "Settings", action = "Index", id = UrlParameter.Optional }
			);
        }
    }
}