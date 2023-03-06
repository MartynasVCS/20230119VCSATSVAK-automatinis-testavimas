using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Threading;

namespace SeleniumFramework
{
    public class Driver
    {
        private static ThreadLocal<IWebDriver> driver= new ThreadLocal<IWebDriver>();

        public static void SetupDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--ignore-certificate-errors");
            //options.AddArgument("--window-size=1920,1080"); // Sets the initial window size. Provided as string in the format "800,600".
            //options.AddArgument("--headless"); // Run in headless mode, i.e., without a UI or display server dependencies.
            //options.AddArgument("--start-maximized"); // Starts the browser maximized, regardless of any previous settings.
            //options.AddArgument("--disable-notifications"); // Disables the Web Notification and the Push APIs.

            driver.Value = new ChromeDriver(options);

            // Another way to maximize window. Does not work with headless mode
            //driver.Manage().Window.Maximize();
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
