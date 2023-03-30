using DesignPatterns.Mediator.Concrete;

namespace DesignPatterns.Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var loginDialog = new LoginDialog();
            loginDialog.loginBtn.Click();

            var registerDialog = new RegisterDialog();
            registerDialog.emailTbx.KeyPress();
        }
    }
}