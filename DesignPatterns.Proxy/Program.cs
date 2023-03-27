using DesignPatterns.Proxy.Abstract;
using DesignPatterns.Proxy.Concrete;

namespace DesignPatterns.Proxy
{
    internal class Program
    {
        private static IService service;

        static void Main(string[] args)
        {
            service = new ProxyClass(new Service());
            service.Operation();
        }
    }
}