﻿using System;
using CroquetAustraliaWebsite.Application.Specifications.Pages.Infrastructure;
using OpenQA.Selenium;

namespace CroquetAustraliaWebsite.Application.Specifications.Helpers
{
    public static class WebDriverExtensions
    {
        public static TPage Goto<TPage>(this IWebDriver webDriver) where TPage : IPage, new()
        {
            var page = new TPage();

            webDriver.Navigate().GoToUrl(page.Url);

            return page;
        }

        public static TPage Post<TPage>(this IWebDriver webDriver) where TPage : IPage, new()
        {
            // todo: implement
            return new TPage();
        }
    }
}
