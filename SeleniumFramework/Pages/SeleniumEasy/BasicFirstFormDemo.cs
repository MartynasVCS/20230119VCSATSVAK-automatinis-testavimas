namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class BasicFirstFormDemo
    {
        public static void ClickGetTotal()
        {
            string locator = "//*[@id='gettotal']/button";
            Common.ClickElement(locator);
        }

        public static void ClickShowMessage()
        {
            string locator = "//*[@id='get-input']/button";
            Common.ClickElement(locator);
        }

        public static void EnterMessage(string message)
        {
            string locator = "//*[@id='get-input']//input";
            Common.SendKeys(locator, message);
        }

        public static void EnterValueA(string value)
        {
            string locator = "//*[@id='sum1']";
            Common.SendKeys(locator, value);
        }

        public static void EnterValueB(string value)
        {
            string locator = "//*[@id='sum2']";
            Common.SendKeys(locator, value);
        }

        public static string GetMessage()
        {
            string locator = "//*[@id='display']";
            return Common.GetElementText(locator);
        }

        public static string GetTotal()
        {
            string locator = "//*[@id='displayvalue']";
            return Common.GetElementText(locator);
        }
    }
}
