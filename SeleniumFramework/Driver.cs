using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace SeleniumFramework
{
    public class Driver
    {
        private static ThreadLocal<IWebDriver> driver= new ThreadLocal<IWebDriver>();
        private static string headless = TestContext.Parameters.Get("headless");
        private static string browser = TestContext.Parameters.Get("browser");
        
        public static void SetupDriver()
        {
            switch (browser)
            {
                case null:
                    throw new Exception("Check whether a .runsettings file is selected and/or parameter named 'browser' exists");
                case "chrome":
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("--ignore-certificate-errors");
                    
                    if (headless == "true")
                    {
                        chromeOptions.AddArgument("--headless"); // Run in headless mode, i.e., without a UI or display server dependencies.
                    }
                    //chromeOptions.AddArgument("--window-size=1920,1080"); // Sets the initial window size. Provided as string in the format "800,600".
                    //chromeOptions.AddArgument("--start-maximized"); // Starts the browser maximized, regardless of any previous settings.
                    //chromeOptions.AddArgument("--disable-notifications"); // Disables the Web Notification and the Push APIs.

                    driver.Value = new ChromeDriver(chromeOptions);

                    // Another way to maximize window. Does not work with headless mode
                    //driver.Manage().Window.Maximize();
                    break;
                case "firefox":
                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    if (headless == "true")
                    {
                        firefoxOptions.AddArguments("--headless");
                    }
                    driver.Value = new FirefoxDriver(firefoxOptions);
                    break;
                default:
                    throw new Exception($"Error in run settings file, there is no browser named '{TestContext.Parameters.Get("browser")}'");
            }
        }

        public static void SetupDriver(string userDataDir, string profileDir)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument($"--user-data-dir={userDataDir}");
            options.AddArgument($"--profile-directory={profileDir}");
            driver.Value = new ChromeDriver(options);
        }

        internal static IWebDriver GetDriver()
        {
            return driver.Value;
        }

        public static void OpenUrl(string url)
        {
            driver.Value.Url = url;
        }

        public static void QuitDriver()
        {
            driver.Value.Quit();
        }

        public static string TakeScreenshot(string methodName)
        {
            string screenshotsDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}screenshots";
            string screenshotName = $"{methodName}-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.png";
            string screenshotFilePath = $"{screenshotsDirectoryPath}\\{screenshotName}";

            Directory.CreateDirectory(screenshotsDirectoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver.Value).GetScreenshot();
            screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
            return screenshotFilePath;
        }
    }
}
