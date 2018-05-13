using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;

namespace seleniumfirst
{
    class Program
    {
        
     

        static void Main(string[] args)
        {
           
        }

        [SetUp]
        public void Initialize()
        {
            //create the reference for our browser
            PropertiesCollection.driver = new ChromeDriver();

            //navigate to google page
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/Login.html");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
 
        //Login to Application
        LoginPageObject pageLogin = new LoginPageObject(PropertiesCollection.driver);
            EAPageObject pageEA =  pageLogin.Login("execute", "automation");


            pageEA.FillUserForm("LB", "Luther", "Huset");



            /* 
             //Title
             SeleniumSetMethods.SelectDropdown("TitleId", "Mr.", PropertyType.Id);

             //Initial 
             SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);

             Console.WriteLine("The value from my title is:" + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Id));

             Console.WriteLine("The value from my initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

             //Click Operation
             SeleniumSetMethods.Click("Save", PropertyType.Name);
            */


            Console.WriteLine("Ran the test");
        }

     //   [Test]
      //  public void NextTest()
      //  {
      //      Console.WriteLine("Next test method");
      //  }

        [TearDown]
        public void CleanUp()
        {
            //close browser
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
