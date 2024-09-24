using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalRecordAutomation
{
    public class LoginUITest
{
        [Test]
        public void TitleTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Navigate().GoToUrl("https://demo.openemr.io/b/openemr");

            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo("OpenEMR Login"));
        }

        [Test]
        public void ApplicationDescriptionTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Navigate().GoToUrl("https://demo.openemr.io/b/openemr");

            //Assert the text --> "The most popular open-source Electronic Health Record and Medical Practice Management solution."
            string ActualDescription = driver.FindElement(By.XPath("//p[@class='text-center lead']")).Text;

            Assert.That(ActualDescription, Is.EqualTo("The most popular open-source Electronic Health Record and Medical Practice Management solution."));
        }


    }
}
