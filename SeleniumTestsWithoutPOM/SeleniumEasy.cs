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

        [Test]
        public void SimpleFormDemoTwoInputFieldsInputs_5_And_2()
        {
            string valueA = "5";
            string valueB = "2";
            string expectedResult = "7";
            
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

        [Test]
        public void SimpleFormDemoTwoInputFieldsInputs_Hello_And_2()
        {
            string valueA = "Hello";
            string valueB = "2";
            string expectedResult = "NaN";

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
