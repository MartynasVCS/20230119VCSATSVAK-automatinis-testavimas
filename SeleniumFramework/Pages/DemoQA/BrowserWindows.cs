namespace SeleniumFramework.Pages.DemoQA
{
    public class BrowserWindows
    {
        public static string GetNewTabHeadingText()
        {
            string handle = Common.GetCurrentWindowHandle();
            Common.SwitchToNewWindowFromCurrentWindowHandle(handle);
            return Common.GetElementText("//*[@id='sampleHeading']");
        }

        public static string GetMainPageHeadingText()
        {
            string handle = Common.GetCurrentWindowHandle();
            Common.SwitchToNewWindowFromCurrentWindowHandle(handle);
            return Common.GetElementText("//*[@class='main-header']");
        }

        public static void ClickNewTabButton()
        {
            Common.ClickElement("//*[@id='tabButton']");
        }
    }
}
