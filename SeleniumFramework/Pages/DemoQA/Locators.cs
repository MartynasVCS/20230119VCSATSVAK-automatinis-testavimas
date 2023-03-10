namespace SeleniumFramework.Pages.DemoQA
{
    internal class Locators
    {
        internal static class TextBox
        {
            internal static string inputFullName = "//*[@id='userName']";
            internal static string inputEmail = "//*[@id='userEmail']";
            internal static string inputCurrentAddress = "//*[@id='currentAddress']";
            internal static string inputPermanentAddress = "//*[@id='permanentAddress']";
            internal static string buttonSubmit = "//*[@id='submit']";
            internal static string outputCurrentAddress = "//*[@id='output']//*[@id='currentAddress']";
            internal static string outputEmail = "//*[@id='output']//*[@id='email']";
            internal static string outputFullName = "//*[@id='output']//*[@id='name']";
            internal static string outputPermanentAddress = "//*[@id='output']//*[@id='permanentAddress']";
        }

        internal static class DynamicProperties
        {
            internal static string buttonFirst = "//*[@id='enableAfter']";
            internal static string buttonSecond = "//*[@id='colorChange']";
            internal static string buttonThird = "//*[@id='visibleAfter']";
        }

        internal static class Buttons
        {
            internal static string buttonDoubleClick = "//*[@id='doubleClickBtn']";
            internal static string outputDoubleClick = "//*[@id='doubleClickMessage']";
            internal static string outputLeftClick = "//*[@id='dynamicClickMessage']";
            internal static string outputRightClick = "//*[@id='rightClickMessage']";
            internal static string buttonLeftClick = "//*[@id='rightClickBtn']/../following-sibling::div/button";
            internal static string buttonRightClick = "//*[@id='rightClickBtn']";
        }

        internal static class SelectMenu
        {
            internal static string selectOldStyle = "//*[@id='oldSelectMenu']";
            internal static string selectSelectOne = "//*[@id='selectOne']";
        }
    }
}
