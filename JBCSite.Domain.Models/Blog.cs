using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBCSite.Domain.Models
{
    public class Blog
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; } = true;
    }
}
