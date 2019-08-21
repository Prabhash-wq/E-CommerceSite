using E_CommerceSite.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSite.Bussiness.DAL
{
   public class SignUpHelper
    {
        public List<SignUpViewModels> ListUser()
        {
            List<SignUpViewModels> data = new List<SignUpViewModels>();
            try
            {
                using (ECommerceDBContext db = new ECommerceDBContext())
                {
                    data = db.SignUpViewModel.ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return data;
        }
    }
}
