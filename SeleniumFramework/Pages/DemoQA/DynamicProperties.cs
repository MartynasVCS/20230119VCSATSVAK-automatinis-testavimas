namespace SeleniumFramework.Pages.DemoQA
{
    public class DynamicProperties
    {
        public static bool CheckIfFirstButtonIsEnabled()
        {
            return Common.GetElementEnabledStatus(Locators.DynamicProperties.buttonFirst); 
        }

        public static void ClickFirstButton()
        {
            Common.ClickElement(Locators.DynamicProperties.buttonFirst);
        }

        public static void WaitForFirstButtonToBeEnabled()
        {
            Common.WaitForElementToBeEnabled(Locators.DynamicProperties.buttonFirst);
        }
    }
}
