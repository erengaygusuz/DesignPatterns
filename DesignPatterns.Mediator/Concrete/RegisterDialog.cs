using DesignPatterns.Mediator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.Concrete
{
    internal class RegisterDialog : IDialog
    {
        public Button registerBtn;
        public Textbox usernameTbx;
        public Textbox passwordTbx;
        public Textbox emailTbx;

        public RegisterDialog()
        {
            registerBtn = new Button(this, "Register Button");
            usernameTbx = new Textbox(this, "Username Textbox");
            passwordTbx = new Textbox(this, "Password Textbox");
            emailTbx = new Textbox(this, "Email Textbox");
        }

        public void Notify(Component sender, string eventName)
        {
            if (sender.name == "Register Button" && eventName == "Click")
            {
                Console.WriteLine("Register button is clicked");
            }

            else if (sender.name == "Username Textbox" && eventName == "KeyPress")
            {
                Console.WriteLine("Username textbox is selected");
            }

            else if (sender.name == "Password Textbox" && eventName == "KeyPress")
            {
                Console.WriteLine("Password textbox is selected");
            }

            else if (sender.name == "Email Textbox" && eventName == "KeyPress")
            {
                Console.WriteLine("Email textbox is selected");
            }
        }
    }
}
