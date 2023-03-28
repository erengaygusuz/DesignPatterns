using DesignPatterns.ChainOfResponsibility.Abstract;
using DesignPatterns.ChainOfResponsibility.Concrete;

namespace DesignPatterns.ChainOfResponsibility
{
    internal class Program
    {
        private static IHandler authHandler;
        private static IHandler cacheHandler;

        static void Main(string[] args)
        {
            authHandler = new AuthHandler();
            cacheHandler = new CacheHandler();

            authHandler.SetNext(cacheHandler);

            MakeRequest();
        }

        static void MakeRequest()
        {
            foreach (var request in new List<string> { "Auth", "Cached" })
            {
                Console.WriteLine($"Client: Who wants a {request}?");

                var result = authHandler.Handle(request);

                if (result != null)
                {
                    Console.WriteLine($"{result} is handled");
                }
                else
                {
                    Console.WriteLine($"{request} is not handled");
                }
            }
        }
    }
}