using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.IO;

namespace SeleniumFramework
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void SetupDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--ignore-certificate-errors");
            driver = new ChromeDriver(options);
        }

        public static void SetupDriver(string userDataDir, string profileDir)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument($"--user-data-dir={userDataDir}");
            options.AddArgument($"--profile-directory={profileDir}");
            driver = new ChromeDriver(options);
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

        public static void TakeScreenshot()
        {
            string screenshotsDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}screenshots";
            string screenshotName = $"screenshot-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.png";
            string screenshotFilePath = $"{screenshotsDirectoryPath}\\{screenshotName}";

            Directory.CreateDirectory(screenshotsDirectoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
        }
    }
}
