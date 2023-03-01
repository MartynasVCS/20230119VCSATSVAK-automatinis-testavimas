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

        public static string GetButtonTextColor()
        {
            return Common.GetElementCssAttributeValue(Locators.DynamicProperties.buttonSecond, "color");
        }

        public static string GetSecondButtonClassAttributeValue()
        {
            return Common.GetElementAttributeValue(Locators.DynamicProperties.buttonSecond, "class");
        }

        public static void WaitForFirstButtonToBeEnabled()
        {
            Common.WaitForElementToBeEnabled(Locators.DynamicProperties.buttonFirst);
        }

        public static void WaitForSecondButtonClassAttributeToContainExpectedValue(string expectedValue)
        {
            Common.WaitForElementAttributeToContainValue(Locators.DynamicProperties.buttonSecond, "class", expectedValue);
        }

        public static void WaitForSecondButtonTextColorToChangeFromDefault(string defaultButtonTextColor)
        {
            Common.WaitForElementCssAttributeValueNotToBe(Locators.DynamicProperties.buttonSecond, "color", defaultButtonTextColor);
        }

        public static void WaitForSecondButtonTextToBeOfProvidedColor(string expectedColor)
        {
            Common.WaitForElementCssAttributeValueToBe(Locators.DynamicProperties.buttonSecond, "color", expectedColor);
        }
    }
}
