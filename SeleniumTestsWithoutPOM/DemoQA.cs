using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumTestsWithoutPOM
{
    internal class DemoQA
    {
        [Test]
        public void FormWithValidData()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            string valueFullName = "Tester";
            string valueEmail = "test@tester.com";
            string valueCurrentAddress = "Test Address";
            string valuePermanentAddress = "Test Address 2";

            IWebElement inputFullName = driver.FindElement(By.XPath("//*[@id='userName']"));
            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            IWebElement inputCurrentAddress = driver.FindElement(By.XPath("//*[@id='currentAddress']"));
            IWebElement inputPermanentAddress = driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id='submit']"));

            inputFullName.SendKeys(valueFullName);
            inputEmail.SendKeys(valueEmail);
            inputCurrentAddress.SendKeys(valueCurrentAddress);
            inputPermanentAddress.SendKeys(valuePermanentAddress);

            driver.ExecuteJavaScript("window.scrollBy(0, 200)");
            buttonSubmit.Click();

            IWebElement outputFullName = driver.FindElement(By.XPath("//*[@id='output']//*[@id='name']"));
            IWebElement outputEmail = driver.FindElement(By.XPath("//*[@id='output']//*[@id='email']"));
            IWebElement outputCurrentAddress = driver.FindElement(By.XPath("//*[@id='output']//*[@id='currentAddress']"));
            IWebElement outputPermanentAddress = driver.FindElement(By.XPath("//*[@id='output']//*[@id='permanentAddress']"));

            Assert.AreEqual($"Name:{valueFullName}", outputFullName.Text);
            Assert.AreEqual($"Email:{valueEmail}", outputEmail.Text);
            Assert.AreEqual($"Current Address :{valueCurrentAddress}", outputCurrentAddress.Text);
            Assert.AreEqual($"Permananet Address :{valuePermanentAddress}", outputPermanentAddress.Text);

            driver.Quit();
        }

        [Test]
        public void FormWithInvalidEmail()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            string valueEmail = "Corrupt";

            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id='submit']"));

            inputEmail.SendKeys(valueEmail);

            driver.ExecuteJavaScript("window.scrollBy(0, 400)");
            buttonSubmit.Click();

            // Patikrinam, kad elementui buvo priskirta atitinkama klasė
            Assert.IsTrue(inputEmail.GetAttribute("class").Contains("field-error"));

            // Patikriname elemento border'io spalvą
            Assert.AreEqual("rgb(255, 0, 0)", inputEmail.GetCssValue("border-color"));

            // Patikriname elemento border'io visą stilių
            Assert.AreEqual("0.519481px solid rgb(255, 0, 0)", inputEmail.GetCssValue("border"));

            driver.Quit();
        }
    }
}
