using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using NUnit;
using NUnit.Framework;

namespace IHSMarkit_Technical_Test.PageObjects
{
    public class TestNumber2Objects
    {
        private IWebDriver driver;

        public TestNumber2Objects(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Xpath is not a preferred locator as it can sometimes require updating if the layout to the site changes
        public IWebElement NuGetPackagesInput => driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/form/div[2]/div[2]/div[5]/div/div/input"));
        public IWebElement NunitMenuItem => driver.FindElement(By.XPath("/html/body/ul/li[1]"));
        public IWebElement onDiskTick => driver.FindElement(By.XPath("/html/body/ul/li[1]/ul/li[1]/a/i"));
        public IWebElement nunitV3120 => driver.FindElement(By.XPath("/html/body/ul/li[1]/ul/li[1]/a"));

        public void enterNunitAndCheckItIsAdded()
        {
            NuGetPackagesInput.Click();
            Thread.Sleep(500);
            NuGetPackagesInput.SendKeys("Nunit");
            Thread.Sleep(1500);

            //check that Nunit is added
            NunitMenuItem.Click();
            Thread.Sleep(2500);
            Assert.True(onDiskTick.Displayed);
            nunitV3120.Click();
            Thread.Sleep(500);

            //check that package is added
            string packageName = driver.FindElement(By.ClassName("package-name")).Text;
            string expectedPackageName = "NUnit";
            Assert.AreEqual(expectedPackageName, packageName);



            
        }
    }

}
