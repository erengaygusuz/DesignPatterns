using DesignPatterns.Facade.Abstract;
using DesignPatterns.Facade.Concrete;

namespace DesignPatterns.Facade
{
    internal class Program
    {
        private static IDatabaseService databaseService;

        static void Main(string[] args)
        {
            databaseService = new Dapper();
            databaseService.ConnectDatabase("127.0.0.1", "8080", "erengaygusuz", "12345");
        }
    }
}