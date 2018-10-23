using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebApplication_Store.Models
{
    public class WebApplication_StoreContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebApplication_StoreContext() : base("name=WebApplication_StoreContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public System.Data.Entity.DbSet<WebApplication_Store.Models.Produto> Produtoes { get; set; }

        public System.Data.Entity.DbSet<WebApplication_Store.Models.TipoDocumento> TipoDocumentoes { get; set; }

        public System.Data.Entity.DbSet<WebApplication_Store.Models.Funcionario> Funcionarios { get; set; }

        public System.Data.Entity.DbSet<WebApplication_Store.Models.Fornecedor> Fornecedors { get; set; }
    }
}
