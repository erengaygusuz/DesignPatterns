using DesignPatterns.Mediator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.Concrete
{
    internal class LoginDialog : IDialog
    {
        public Button loginBtn;
        public Textbox usernameTbx;
        public Textbox passwordTbx;

        public LoginDialog()
        {
            loginBtn = new Button(this, "Login Button");
            usernameTbx = new Textbox(this, "Username Textbox");
            passwordTbx = new Textbox(this, "Password Textbox");
        }

        public void Notify(Component sender, string eventName)
        {
            if (sender.name == "Login Button" && eventName == "Click") 
            {
                Console.WriteLine("Login button is clicked");
            }

            else if (sender.name == "Username Textbox" && eventName == "KeyPress")
            {
                Console.WriteLine("Username textbox is selected");
            }

            else if (sender.name == "Password Textbox" && eventName == "KeyPress")
            {
                Console.WriteLine("Password textbox is selected");
            }
        }
    }
}
