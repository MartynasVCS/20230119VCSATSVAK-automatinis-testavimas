using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumFramework.Pages
{
    public class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        private static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void ClickElements(string locator)
        {
            List<IWebElement> elements = GetElements(locator);
            
            foreach (IWebElement element in elements)
            {
                element.Click();
            }
        }

        internal static string GetElementAttributeValue(string locator, string attributeName)
        {
            return GetElement(locator).GetAttribute(attributeName);
        }

        internal static void ExecuteJavaScript(string script)
        {
            Driver.GetDriver().ExecuteJavaScript(script);
        }

        internal static void ScrollByPixels(int pixelsRight, int pixelsDown)
        {
            ExecuteJavaScript($"window.scrollBy({pixelsRight}, {pixelsDown})");
        }

        internal static void ScrollUntilElementIsClickable(string locator)
        {
            IWebElement element = GetElement(locator);

            bool isClickable = false;
            int maxTries = 10;
            int currentTry = 0;

            while (!isClickable)
            {
                try
                {
                    element.Click();
                    isClickable = true;
                }
                catch(Exception exception)
                {
                    if (exception is ElementClickInterceptedException && currentTry < maxTries)
                    {
                        ExecuteJavaScript("window.scrollBy(0, 50)");
                        currentTry++;
                    }
                    else
                    {
                        throw exception;
                    }
                }
            }
        }

        internal static string GetElementCssAttributeValue(string locator, string cssAttributeName)
        {
            return GetElement(locator).GetCssValue(cssAttributeName);
        }

        internal static bool GetElementEnabledStatus(string locator)
        {
            return GetElement(locator).Enabled;
        }

        internal static void WaitForElementToBeEnabled(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.FindElement(By.XPath(locator)).Enabled);
        }

        internal static void WaitForElementCssAttributeValueToBe(string locator, string cssAttributeName, string expectedCssAttributeValue)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            // Used for debugging purposes
            //System.Threading.Thread.Sleep(6000);
            //Console.WriteLine(GetElement(locator).GetCssValue(cssAttributeName));
            wait.Until(driver => driver.FindElement(By.XPath(locator)).GetCssValue(cssAttributeName) == expectedCssAttributeValue);
        }

        internal static void WaitForElementCssAttributeValueNotToBe(string locator, string cssAttributeName, string cssAttributeValue)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.FindElement(By.XPath(locator)).GetCssValue(cssAttributeName) != cssAttributeValue);
        }

        internal static void WaitForElementAttributeToContainValue(string locator, string attributeName, string expectedAttributeValue)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.FindElement(By.XPath(locator)).GetAttribute(attributeName).Contains(expectedAttributeValue));
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        internal static bool GetElementDisplayedStatus(string locator)
        {
            return GetElement(locator).Displayed;
        }

        internal static void DoubleClickElement(string locator)
        {
            Actions actions = new Actions(Driver.GetDriver());
            IWebElement element = GetElement(locator);

            actions.DoubleClick(element);
            actions.Perform();
        }

        private static SelectElement GetSelectElement(string locator)
        {
            IWebElement element = GetElement(locator);
            return new SelectElement(element);
        }

        internal static void SelectOptionByText(string locator, string text)
        {
            SelectElement selectElement = GetSelectElement(locator);
            selectElement.SelectByText(text);
        }

        internal static string GetSelectedOptionText(string locator)
        {
            SelectElement selectElement = GetSelectElement(locator);
            return selectElement.SelectedOption.Text;
        }

        internal static void AcceptAlert()
        {
            Driver.GetDriver().SwitchTo().Alert().Accept();
        }

        internal static string GetAlertText()
        {
            return Driver.GetDriver().SwitchTo().Alert().Text;
        }

        internal static void DismissAlert()
        {
            Driver.GetDriver().SwitchTo().Alert().Dismiss();
        }

        internal static bool CheckIfAlertIsActive()
        {
            try
            {
                Driver.GetDriver().SwitchTo().Alert();
                return true;
            }
            catch (Exception ex)
            {
                if (ex is NoAlertPresentException)
                {
                    return false;
                }
                else
                {
                    throw ex;
                }
            }
        }

        internal static void SendKeysToAlert(string keys)
        {
            Driver.GetDriver().SwitchTo().Alert().SendKeys(keys);
        }

        internal static void WaitForElementToNotContainText(string locator, string text)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(driver => !driver.FindElement(By.XPath(locator)).Text.Contains(text));
        }
    }
}
