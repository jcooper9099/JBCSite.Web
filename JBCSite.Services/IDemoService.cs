using System.Collections.Generic;
using JBCSite.Domain.Models;

namespace JBCSite.Services
{
    public interface IDemoService
    {
        void Dispose();
        DemoObject GetDemo(int id);
        IEnumerable<DemoObject> GetDemos();
        IEnumerable<DemoSummary> GetSummaries();
        DemoSummary GetSummary(int id);
    }
}