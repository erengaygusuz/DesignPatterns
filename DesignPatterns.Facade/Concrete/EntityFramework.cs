using DesignPatterns.Facade.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Concrete
{
    internal class EntityFramework : IDatabaseService
    {
        public void ConnectDatabase(string address, string port, string username, string password)
        {
            Console.WriteLine(address + ", " + port + ", " + username + ", " + password);
            Console.WriteLine("Database Connection is Established with Entity Framework");
        }
    }
}
