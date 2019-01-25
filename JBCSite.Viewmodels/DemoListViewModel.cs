using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBCSite.Domain.Models;

namespace JBCSite.Viewmodels
{
    public class DemoListViewModel
    {
        public List<DemoSummary> InfoList { get; set; } = new List<DemoSummary>();
    }
}
