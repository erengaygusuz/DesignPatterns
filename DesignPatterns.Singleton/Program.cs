namespace DesignPatterns.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmailHelper.Instance.SendEmail("Example Message");
        }
    }
}