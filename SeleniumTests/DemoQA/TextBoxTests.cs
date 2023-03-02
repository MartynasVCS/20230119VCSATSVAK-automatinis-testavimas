using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.DemoQA;

namespace SeleniumTests.DemoQA
{
    internal class TextBoxTests
    {
        [SetUp]
        public void Open()
        {
            Driver.OpenUrl("https://demoqa.com/text-box");
        }

        [Test]
        public void FormWithValidData()
        {
            string valueFullName = "Tester";
            string valueEmail = "test@tester.com";
            string valueCurrentAddress = "Test Address";
            string valuePermanentAddress = "Test Address 2";

            TextBox.EnterFullName(valueFullName);
            TextBox.EnterEmail(valueEmail);
            TextBox.EnterCurrentAddress(valueCurrentAddress);
            TextBox.EnterPermanentAddress(valuePermanentAddress);
            TextBox.ClickSubmitButton();

            Assert.AreEqual($"Name:{valueFullName}", TextBox.GetFullName());
            Assert.AreEqual($"Email:{valueEmail}", TextBox.GetEmail());
            Assert.AreEqual($"Current Address :{valueCurrentAddress}", TextBox.GetCurrentAddress());
            Assert.AreEqual($"Permananet Address :{valuePermanentAddress}", TextBox.GetPermanentAddress());
        }

        [Test]
        public void FormWithInvalidEmail()
        {
            string valueEmail = "Corrupt";

            TextBox.EnterEmail(valueEmail);
            TextBox.ClickSubmitButton();

            // Patikrinam, kad elementui buvo priskirta atitinkama klasė
            Assert.IsTrue(TextBox.CheckIfEmailIsWrongFormat());

            // Patikriname elemento border'io spalvą
            Assert.AreEqual("rgb(255, 0, 0)", TextBox.GetEmailInputBorderColor());

            // Patikriname elemento border'io visą stilių
            Assert.AreEqual("0.519481px solid rgb(255, 0, 0)", TextBox.GetEmailInputBorderStyle());
        }
    }
}
