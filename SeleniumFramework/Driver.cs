using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumFramework
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void SetupDriver()
        {
            driver = new ChromeDriver();
        }

        internal static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void OpenUrl(string url)
        {
            driver.Url = url;
        }

        public static void QuitDriver()
        {
            driver.Quit();
        }
    }
}
