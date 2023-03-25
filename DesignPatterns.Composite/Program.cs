using DesignPatterns.Composite.Abstract;
using DesignPatterns.Composite.Concrete;

namespace DesignPatterns.Composite
{
    internal class Program
    {
        private static List<IJob> jobs;

        static void Main(string[] args)
        {
            jobs = new List<IJob>();

            jobs.Add(new Employee());

            var workspace = new Workspace();
            workspace.AddJob(new Employee());
            workspace.AddJob(new Employee());

            jobs.Add(workspace);

            jobs.ForEach(job =>
            {
                job.DoWork();
            });
        }
    }
}