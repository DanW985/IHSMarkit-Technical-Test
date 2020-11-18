using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using IHSMarkit_Technical_Test.Base;
using IHSMarkit_Technical_Test.PageObjects;

namespace IHSMarkit_Technical_Test
{
    public class Tests:BaseClass
    {
        [Test]
        public void Click_Run_And_Check_That_Output_Contains_Hello_World()
        {
            try
            {
                var test1 = new TestNumber1Objects(driver);

                test1.clickTheRunButtonAndCheckOutput();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        [Test]
        public void Select_NuGet_Packages_And_Confirm_Nunit_Package_Is_Added()
        {
            try
            {
                var test2 = new TestNumber2Objects(driver);

                test2.enterNunitAndCheckItIsAdded();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
