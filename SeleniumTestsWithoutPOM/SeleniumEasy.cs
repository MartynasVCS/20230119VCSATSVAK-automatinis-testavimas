using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestsWithoutPOM
{
    internal class SeleniumEasy
    {
        [Test]
        public void SimpleFormDemoSingleInputField()
        {
            string expectedResult = "Hello World";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            IWebElement inputEnterMessage = driver.FindElement(By.XPath("//*[@id='get-input']//input"));
            inputEnterMessage.SendKeys(expectedResult);

            IWebElement buttonShowMessage = driver.FindElement(By.XPath("//*[@id='get-input']/button"));
            buttonShowMessage.Click();

            IWebElement spanMessage = driver.FindElement(By.XPath("//*[@id='display']"));
            string actualResult = spanMessage.Text;

            driver.Quit();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
