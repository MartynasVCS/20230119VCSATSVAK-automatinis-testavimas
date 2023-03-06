using System;

namespace SeleniumFramework.Pages.DemoQA
{
    public class Buttons
    {
        public static void DoubleClickButton()
        {
            Common.DoubleClickElement(Locators.Buttons.buttonDoubleClick);
        }

        public static string GetDoubleClickActionOutput()
        {
            return Common.GetElementText(Locators.Buttons.outputDoubleClick);
        }

        public static string GetLeftClickActionOutput()
        {
            Common.WaitForElementToBeVisible(Locators.Buttons.outputLeftClick);
            return Common.GetElementText(Locators.Buttons.outputLeftClick);
        }

        public static string GetRightClickActionOutput()
        {
            return Common.GetElementText(Locators.Buttons.outputRightClick);
        }

        public static void LeftClickButton()
        {
            Common.ScrollUntilElementIsClickable(Locators.Buttons.buttonLeftClick);
            Common.LeftClickElement(Locators.Buttons.buttonLeftClick);
        }

        public static void RightClickButton()
        {
            Common.RightClickElement(Locators.Buttons.buttonRightClick);
        }
    }
}
