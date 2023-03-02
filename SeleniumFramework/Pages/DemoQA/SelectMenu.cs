namespace SeleniumFramework.Pages.DemoQA
{
    public class SelectMenu
    {
        public static string GetSelectedValueInOldStyleMenu()
        {
            return Common.GetSelectedOptionText(Locators.SelectMenu.selectOldStyle);
        }

        public static string GetSelectedValueInSelectOneMenu()
        {
            return Common.GetElementText(Locators.SelectMenu.selectSelectOne);
        }

        public static void SelectOptionInOldStyleMenu(string optionText)
        {
            Common.SelectOptionByText(Locators.SelectMenu.selectOldStyle, optionText);
        }

        public static void SelectValueInSelectOneMenu(string value)
        {
            string valueLocator = $"//*[@id='selectOne']//*[contains(@id,'react-select') and text()='{value}']";
            Common.ScrollByPixels(0, 400);
            Common.ClickElement(Locators.SelectMenu.selectSelectOne);
            Common.ClickElement(valueLocator);
        }
    }
}
