﻿using System;
using System.Web.Http;
using DataBooster.DbWebApi;

namespace MyDbWebApi
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			config.Routes.MapHttpRoute(
				name: "DbWebApi",
				routeTemplate: "{sp}",
				defaults: new { controller = "DbWebApi" }
			);

			config.SupportCsvMediaType();
			DbWebApiOptions.DerivedParametersCacheExpireInterval = new TimeSpan(0, 15, 0);
		}
	}
}