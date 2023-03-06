namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class DynamicDataLoading
    {
        public static void ClickGetNewUserButton()
        {
            Common.ClickElement("//*[@id='save']");

            string locator = "//*[@id='loading']";
            Common.WaitForElementToNotContainText(locator, "loading...");
        }

        public static string GetUserInformation()
        {
            return Common.GetElementText("//*[@id='loading']");
        }
    }
}
