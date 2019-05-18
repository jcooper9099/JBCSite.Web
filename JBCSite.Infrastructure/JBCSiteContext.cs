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

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<BlogUser> BlogUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}
