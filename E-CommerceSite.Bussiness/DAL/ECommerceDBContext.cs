using E_CommerceSite.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSite.Bussiness.DAL
{

    public class ECommerceDBContext : DbContext
    {
        public ECommerceDBContext() : base("ECommerceDBConnection")
        {

        }

        public DbSet<SignUpViewModels> SignUpViewModel { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
