using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBCSite.Domain.Models
{
    /// <summary>
    /// Summary information for Demo objects
    /// </summary>
    public class DemoInfo
    {
        /// <summary>
        /// For persisting the object in the Db
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Holds the Id of demo object this item represents
        /// </summary>
        public int DemoId { get; set; }

        /// <summary>
        /// Serves as the title of the demo
        /// </summary>
        public string DemoTitle { get; set; }

        /// <summary>
        /// A short description of what the demo object contains
        /// </summary>
        public string DemoDescription { get; set; }

        /// <summary>
        /// a virtual object which is refernced by DemoId
        /// Useful for Entity Framework foreign key relationships
        /// </summary>
        public virtual DemoObject Demo { get; set; }
    }
}
