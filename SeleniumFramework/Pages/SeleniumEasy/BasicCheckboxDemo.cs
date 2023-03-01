namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class BasicCheckboxDemo
    {
        public static void ClickMultipleCheckboxes()
        {
            string locator = "//*[@class='cb1-element']";
            Common.ClickElements(locator);
        }

        public static string GetButtonText()
        {
            string locator = "//*[@id='check1']";
            return Common.GetElementAttributeValue(locator, "value");
        }
    }
}
