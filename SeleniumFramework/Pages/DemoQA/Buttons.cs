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
    }
}
