namespace JBCSite.Infrastructure
{
    using JBCSite.Domain.Models;
    using JBCSite.Infrastructure.Repository;
    using System.Data.Entity;
    using System.Data.Entity.SqlServer;

    public partial class SiteContext : System.Data.Entity.DbContext, IDbContext
    {
        public bool IsDisposed { get; set; }

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

        public SqlProviderServices GetSqlProviderInstance()
        { return SqlProviderServices.Instance; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

        protected override void Dispose(bool disposing)
        {
            if (!IsDisposed)
            {
                if (disposing)
                {
                    this.Dispose();
                }

                IsDisposed = true;
            }
        }
    }
}
