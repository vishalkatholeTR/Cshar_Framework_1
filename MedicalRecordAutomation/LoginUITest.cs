using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using TR.MedicalRecordAutomation.Base;

namespace TR.MedicalRecordAutomation
{ 
    public class LoginUITest : AutomationWrapper

    {
        
            [Test]
        public void TitleTest()
        {
           
            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo("OpenEMR Login"));
        }

        [Test]
        public void ApplicationDescriptionTest()
        {
            //Assert the text --> "The most popular open-source Electronic Health Record and Medical Practice Management solution."
            string ActualDescription = driver.FindElement(By.XPath("//p[@class='text-center lead']")).Text;

            Assert.That(ActualDescription, Is.EqualTo("The most popular open-source Electronic Health Record and Medical Practice Management solution."));
        }


    }
}
