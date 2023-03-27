using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton.Concrete
{
    internal class EmailHelper
    {
        private static EmailHelper instance;

        private EmailHelper() { }

        public static EmailHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmailHelper();
                }

                return instance;
            }
        }

        public void SendEmail(string message)
        {
            Console.WriteLine(message + " is sent.");
        }
    }
}
