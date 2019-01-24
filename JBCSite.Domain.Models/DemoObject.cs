using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBCSite.Domain.Models
{
    /// <summary>
    /// An object which represents a single demonstration of a particular skill
    /// </summary>
    public class DemoObject
    {
        /// <summary>
        /// Serves as Id for db persistance
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// A large amount of text, html or other markup to be displayed on a demo page
        /// </summary>
        public string DemoText { get; set; }
    }
}
