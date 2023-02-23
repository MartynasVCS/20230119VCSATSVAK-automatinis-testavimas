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

        [TestCase("5", "2", "7")]
        [TestCase("Hello", "2", "NaN")]
        public void SimpleFormDemoTwoInputFields(string valueA, string valueB, string expectedResult)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            IWebElement inputA = driver.FindElement(By.XPath("//*[@id='sum1']"));
            IWebElement inputB = driver.FindElement(By.XPath("//*[@id='sum2']"));
            IWebElement buttonGetTotal = driver.FindElement(By.XPath("//*[@id='gettotal']/button"));
            IWebElement spanTotal = driver.FindElement(By.XPath("//*[@id='displayvalue']"));

            inputA.SendKeys(valueA);
            inputB.SendKeys(valueB);
            buttonGetTotal.Click();
            string actualResult = spanTotal.Text;

            driver.Quit();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
