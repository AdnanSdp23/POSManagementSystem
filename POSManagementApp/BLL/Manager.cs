using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using POSManagementApp.Model;
using POSManagementApp.DAL;

namespace POSManagementApp.BLL
{
    class Manager
    {
        Gateway aGateway = new Gateway();
         public bool SaveGategory(Category aCategory)
        {
            return aGateway.InsertCategory(aCategory) > 0;
        }

        public bool SaveBrand(Brand aBrand)
        {
            return aGateway.InsertBrand(aBrand) > 0;
        }

        public bool SaveProduct(product aProduct)
        {
            return aGateway.InsertProduct(aProduct) > 0;
        }

        public decimal TotalAmount(product aProduct)
        {
            return aProduct.Unit*aProduct.Price;
        }

        public List<AllProducts> AllProducts()
        {
            return aGateway.AllProducs();
        }
    }
}
