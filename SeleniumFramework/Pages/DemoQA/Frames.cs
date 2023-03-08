namespace SeleniumFramework.Pages.DemoQA
{
    public class Frames
    {
        public static string GetFrameHeadingText()
        {
            Common.SwitchToIframeByLocator("//*[@id='frame1']");
            return Common.GetElementText("//*[@id='sampleHeading']");
        }

        public static string GetMainPageHeadingText()
        {
            Common.SwitchToDefaultContent();
            return Common.GetElementText("//*[@class='main-header']");
        }
    }
}
