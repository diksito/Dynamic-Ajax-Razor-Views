using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DynamicTemplates.Models;

namespace DynamicTemplates.DAL
{
    public class TemplateContext : DbContext
    {
        public TemplateContext() : base("TemplateContext")
        {

        }

        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}