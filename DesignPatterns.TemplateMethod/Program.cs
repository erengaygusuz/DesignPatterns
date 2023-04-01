using DesignPatterns.TemplateMethod.Concrete;

namespace DesignPatterns.TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var template = new DerivedA();
            template.TemplateMethod();
        }
    }
}