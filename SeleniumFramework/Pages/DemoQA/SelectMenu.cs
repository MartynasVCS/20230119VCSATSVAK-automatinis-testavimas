namespace SeleniumFramework.Pages.DemoQA
{
    public class SelectMenu
    {
        public static string GetSelectedValueInOldStyleMenu()
        {
            return Common.GetSelectedOptionText(Locators.SelectMenu.selectOldStyle);
        }

        public static void SelectOptionInOldStyleMenu(string optionText)
        {
            Common.SelectOptionByText(Locators.SelectMenu.selectOldStyle, optionText);
        }
    }
}
