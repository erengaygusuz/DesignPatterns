using DesignPatterns.Adapter.Abstract;
using DesignPatterns.Adapter.Concrete;

namespace DesignPatterns.Adapter
{
    internal class Program
    {
        private static IDataProvider dataProvider;
        private static Xml data;

        static void Main(string[] args)
        {
            dataProvider = new DataWrapper();

            data = dataProvider.GetData();

            Console.WriteLine(data.Value);
        }
    }
}