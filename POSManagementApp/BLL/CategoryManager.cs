using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSManagementApp.DAL;
using POSManagementApp.Model;

namespace POSManagementApp.BLL
{
    class CategoryManager
    {
        CategoryGateway aCategoryGateway = new CategoryGateway();
        public List<Category> GetAllCategories()
        {
           // return aCate.GetAllDesignations();
            return aCategoryGateway.GetAllCategories();
        }
    }
}
