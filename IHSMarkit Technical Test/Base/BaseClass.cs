using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using System.Threading;


namespace IHSMarkit_Technical_Test.Base
{
    public class BaseClass
    {
        //Arrange - creating an instance of the web driver, setting thr URL as a string to use as a parameter
        public IWebDriver driver;
        private const string URL = "https://dotnetfiddle.net";

        //Act - now that the web driver has been created we will use that instance to navigate to the URL specified in the string
        [OneTimeSetUp]
        public void BeforeTest()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(URL);
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            //Assert ensure that the webpage has opened by locating an element on the page
            var runButton = driver.FindElement(By.Id("run-button"));
            Assert.True(runButton.Displayed);
        }

        

        [TearDown]
        public void endOfTest()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
