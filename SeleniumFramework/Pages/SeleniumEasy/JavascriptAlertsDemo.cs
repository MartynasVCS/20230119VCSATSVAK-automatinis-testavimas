namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class JavascriptAlertsDemo
    {
        public static bool CheckIfAlertIsActive()
        {
            return Common.CheckIfAlertIsActive();
        }

        public static void ClickSimpleAlertButton()
        {
            Common.ClickElement("(//*[contains(@class,'panel-primary')])[1]//button");
        }

        public static void AcceptAlert()
        {
            Common.AcceptAlert();
        }

        public static string GetAlertText()
        {
            return Common.GetAlertText();
        }

        public static void ClickConfirmAlertButton()
        {
            Common.ClickElement("(//*[contains(@class,'panel-primary')])[2]//button");
        }

        public static string GetConfirmAlertMessage()
        {
            return Common.GetElementText("//*[@id='confirm-demo']");
        }

        public static void DismissAlert()
        {
            Common.DismissAlert();
        }

        public static void ClickPromptAlertButton()
        {
            Common.ClickElement("(//*[contains(@class,'panel-primary')])[3]//button");
        }

        public static void EnterMessageToPromptAlert(string expectedMessage)
        {
            Common.SendKeysToAlert(expectedMessage);
        }

        public static string GetPromptAlertMessage()
        {
            return Common.GetElementText("//*[@id='prompt-demo']");
        }
    }
}
