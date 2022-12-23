﻿using DummyBazaarBerko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DummyBazaarBerko.Areas.AdminPanel.Filters
{
    public class ManagerTypeAuthenticationFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Manager m = (Manager)filterContext.RequestContext.HttpContext.Session["adminSession"];
            if (m.ManagerType_ID != 1)
            {
                filterContext.RequestContext.HttpContext.Response.Redirect("~/AdminPanel/YetkiYetersiz/Index");
            }
            base.OnActionExecuted(filterContext);
        }
    }
}