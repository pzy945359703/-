﻿using System.Web.Mvc;

namespace WebApplication1.Areas.First
{
    public class FirstAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "First";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "First_default",
                "First/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}