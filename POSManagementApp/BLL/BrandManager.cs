using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSManagementApp.DAL;
using POSManagementApp.Model;

namespace POSManagementApp.BLL
{
    class BrandManager
    {
      BrandGateway aBrandGateway = new BrandGateway();

        public List<Brand> GetAllBrands()
        {
            return aBrandGateway.GetAllBrands();
        }
    }
}
