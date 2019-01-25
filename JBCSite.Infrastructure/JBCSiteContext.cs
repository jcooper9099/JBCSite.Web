namespace JBCSite.Infrastructure
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using JBCSite.Domain.Models;

    public partial class JBCSiteContext : DbContext
    {
        public JBCSiteContext()
            : base("name=JBCSiteContext")
        {
        }

        public DbSet<DemoInfo> DemoInfos { get; set; }

        public DbSet<DemoObject> DemoObjects { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
