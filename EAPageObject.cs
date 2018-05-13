using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumfirst
{
    public class EAPageObject
    {

        /*
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement ddlTitleId { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }
        */


        // New Way of initializing pages!!!
        private RemoteWebDriver _driver;


        public EAPageObject(RemoteWebDriver driver) => _driver = driver;


        IWebElement ddlTitleId => _driver.FindElementByName("TitleId");
        IWebElement txtInitial => _driver.FindElementByName("Initial");
        IWebElement txtMiddleName => _driver.FindElementByName("MiddleName");
        IWebElement txtFirstName => _driver.FindElementByName("FirstName");
        IWebElement btnSave => _driver.FindElementByName("Save");

        public void FillUserForm(string initial, string middlename, string firstname)
        {
            txtInitial.EnterText(initial);
            txtFirstName.EnterText(firstname);
            txtMiddleName.EnterText(middlename);
            btnSave.Clicks();

            /*
            SeleniumSetMethods.EnterText(txtInitial, initial);
            SeleniumSetMethods.EnterText(txtFirstName, firstname);
            SeleniumSetMethods.EnterText(txtMiddleName, middlename);
            SeleniumSetMethods.Clicks(btnSave);
            */
            /*
            txtInitial.SendKeys(initial);
            txtMiddleName.SendKeys(middlename);
            txtFirstName.SendKeys(firstname);
            btnSave.Click();
            */
        }


    }
}
