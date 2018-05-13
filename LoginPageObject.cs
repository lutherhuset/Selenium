using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumfirst
{
    class LoginPageObject
    {

        /*  OLD WAY -- NOW OBSOLETE
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }
        */


        // New Way of initializing pages!!!
        public RemoteWebDriver _driver;


        public LoginPageObject(RemoteWebDriver driver) => _driver = driver;

        IWebElement txtUserName => _driver.FindElementByName("UserName");
        IWebElement txtPassword => _driver.FindElementByName("Password");
        IWebElement btnLogin => _driver.FindElementByName("Login");

        public EAPageObject Login(string userName, string password)
        {
            //Username
            txtUserName.EnterText(userName);
            //Password
            txtPassword.EnterText(password);
            //click login
            btnLogin.Submit();


            //return the page object
            return new EAPageObject(_driver);
        }

    }

}
