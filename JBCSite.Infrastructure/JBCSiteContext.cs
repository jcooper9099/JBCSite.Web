namespace JBCSite.Infrastructure
{
    using JBCSite.Domain.Models;
    using System.Data.Entity;

    public partial class JBCSiteContext : DbContext
    {
        public JBCSiteContext()
            : base("name=JBCSiteContext")
        {
        }        

        public DbSet<DemoSummary> DemoSummaries { get; set; }

        public DbSet<DemoObject> DemoObjects { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}
