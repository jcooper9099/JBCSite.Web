namespace JBCSite.Infrastructure
{
    using JBCSite.Domain.Models;
    using JBCSite.Infrastructure.Repository;
    using System.Data.Entity;

    public partial class SiteContext : System.Data.Entity.DbContext, IDbContext
    {
        public SiteContext()
            : base("name=JBCSiteContext")
        {
        }
        
        public SiteContext(string qualifiedName): base($"name={qualifiedName}")
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
