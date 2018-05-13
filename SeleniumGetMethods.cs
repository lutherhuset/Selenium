using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumfirst
{
    class SeleniumGetMethods
    {
        //GetText(element, value, type)
        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");
        }

        //GetText from dropdown lists(element, value, type)
        public static string GetTextFromDDL(IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }


    }
}
