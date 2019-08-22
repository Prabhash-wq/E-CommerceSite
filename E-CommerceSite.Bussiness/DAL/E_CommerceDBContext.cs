using E_CommerceSite.DataLayer.Data_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace E_CommerceSite.Bussiness.DAL
{
    public class E_CommerceDBContext:DbContext
    {
        public E_CommerceDBContext() : base("ECommerceDBConnection")
        {

        }

        public DbSet<SignUpViewModels> SignUpViewModel { get; set; }
    }
}
