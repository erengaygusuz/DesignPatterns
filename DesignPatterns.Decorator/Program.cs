using DesignPatterns.Decorator.Abstract;
using DesignPatterns.Decorator.Concrete;

namespace DesignPatterns.Decorator
{
    internal class Program
    {
        private static IDataSource dataSource;

        static void Main(string[] args)
        {
            dataSource = new FileDataSource();
            dataSource.WriteData();
            dataSource.ReadData();

            dataSource = new CompressDataDecorator(new RemoteDataSource());
            dataSource.WriteData();
            dataSource.ReadData();
        }
    }
}