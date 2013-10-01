using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAPIDemo
{
	public class WebApiApplication : HttpApplication
	{
		protected void Application_Start()
		{
			Console.WriteLine ("------ START -------");
			AreaRegistration.RegisterAllAreas();

			WebApiConfig.Register(GlobalConfiguration.Configuration);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
		}
	}
}
