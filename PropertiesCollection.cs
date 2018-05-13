using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumfirst
{

    public enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }


    class PropertiesCollection
    {


        //Autoimplemented Property
        public static RemoteWebDriver driver { get; set; }
    }
}
