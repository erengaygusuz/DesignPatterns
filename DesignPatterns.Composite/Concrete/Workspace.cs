using DesignPatterns.Composite.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite.Concrete
{
    internal class Workspace : IJob
    {
        private List<IJob> jobs;

        public Workspace()
        {
            jobs = new List<IJob>();
        }

        public void AddJob(IJob job)
        {
            jobs.Add(job);
        }

        public void RemoveJob(IJob job)
        {
            jobs.Remove(job);
        }

        public List<IJob> GetJobs()
        {
            return jobs;
        }

        public void DoWork()
        {
            jobs.ForEach(job =>
            {
                job.DoWork();
            });
        }
    }
}
