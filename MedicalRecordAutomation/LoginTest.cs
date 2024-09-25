using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.MedicalRecordAutomation.Base;
using TR.MedicalRecordAutomation.Utilities;

namespace TR.MedicalRecordAutomation
{
    public class LoginTest : AutomationWrapper
    {
        //Check
          [Test]
        [TestCaseSource(typeof(DataSource),nameof(DataSource.ValidData))]
        public void ValidLoginTest(string username, string password, string expectedresult)
        {

            driver.FindElement(By.Id("authUser")).SendKeys(username);
            driver.FindElement(By.CssSelector("#clearPass")).SendKeys(password);
            driver.FindElement(By.Id("login-button")).Click();

            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo(expectedresult));
        }
        [Test]
        [TestCase("VK123", "OKL", "Invalid username or password")]
        [TestCase("TRUSER", "TR456", "Invalid username or password")]
        public void invalidLogin(string username,string pass,string errormessage)
        {
            driver.FindElement(By.Id("authUser")).SendKeys(username);
            driver.FindElement(By.CssSelector("#clearPass")).SendKeys(pass);
            driver.FindElement(By.Id("login-button")).Click();

            string ActualError = driver.FindElement(By.XPath("//p[text()='Invalid username or password']")).Text;
            Assert.That(ActualError.Contains(errormessage));
        }

    }
}
