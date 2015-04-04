﻿using System.Web.Mvc;

namespace CroquetAustraliaWebsite.Application.App.Infrastructure
{
    [AdminAuthorize]
    public abstract class AdminController : ApplicationController
    {
        protected override IViewModel CreateDefaultViewModel()
        {
            return new AdminViewModel();
        }

        protected override string GetFeatureViewName(string controllerName, string viewName)
        {
            return string.Format("~/App/admin/{0}/{1}.cshtml", controllerName, viewName);
        }
    }
}