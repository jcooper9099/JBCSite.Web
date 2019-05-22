namespace JBCSite.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using JBCSite.Domain.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<JBCSite.Infrastructure.SiteContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SiteContext context)
        {
            if (System.Diagnostics.Debugger.IsAttached == false)
            {
                System.Diagnostics.Debugger.Launch();
            }

            var demo = new DemoObject
            {
                DemoText = @"<p>This demonstration is about MVC itself and how it can be 
                            sed as a powerful way to quickly get ideas from 
                            conception to reality"
            };            

            var demoInfo = new DemoSummary
            {
                DemoTitle = "Basic MVC Skills",
                DemoDescription = "A post to show basic familarity with MVC",
                Demo = demo
            };

            context.DemoSummaries.Add(demoInfo);
            context.SaveChanges();

        
        }
    }
}
