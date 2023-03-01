using System;

namespace SeleniumFramework.Pages.DemoQA
{
    public class TextBox
    {
        public static string GetEmailInputBorderColor()
        {
            return Common.GetElementCssAttributeValue(Locators.TextBox.inputEmail, "border-color");
        }

        public static bool CheckIfEmailIsWrongFormat()
        {
            string attributeValue = Common.GetElementAttributeValue(Locators.TextBox.inputEmail, "class");
            return attributeValue.Contains("field-error");
        }

        public static void ClickSubmitButton()
        {
            Common.ScrollUntilElementIsClickable(Locators.TextBox.buttonSubmit);
            Common.ClickElement(Locators.TextBox.buttonSubmit);
        }

        public static void EnterCurrentAddress(string valueCurrentAddress)
        {
            Common.SendKeys(Locators.TextBox.inputCurrentAddress, valueCurrentAddress);
        }

        public static void EnterEmail(string valueEmail)
        {
            Common.SendKeys(Locators.TextBox.inputEmail, valueEmail);
        }

        public static void EnterFullName(string valueFullName)
        {
            Common.SendKeys(Locators.TextBox.inputFullName, valueFullName);
        }

        public static void EnterPermanentAddress(string valuePermanentAddress)
        {
            Common.SendKeys(Locators.TextBox.inputPermanentAddress, valuePermanentAddress);
        }

        public static string GetCurrentAddress()
        {
            return Common.GetElementText(Locators.TextBox.outputCurrentAddress);
        }

        public static string GetEmail()
        {
            return Common.GetElementText(Locators.TextBox.outputEmail);
        }

        public static string GetFullName()
        {
            return Common.GetElementText(Locators.TextBox.outputFullName);
        }

        public static string GetPermanentAddress()
        {
            return Common.GetElementText(Locators.TextBox.outputPermanentAddress);
        }

        public static string GetEmailInputBorderStyle()
        {
            return Common.GetElementCssAttributeValue(Locators.TextBox.inputEmail, "border");
        }
    }
}
