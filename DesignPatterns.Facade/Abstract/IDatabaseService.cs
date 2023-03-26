using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Abstract
{
    internal interface IDatabaseService
    {
        void ConnectDatabase(string address, string port, string username, string password);
    }
}
