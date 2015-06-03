using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSManagementApp.Model
{
    class product
    {
        public string Purchase_No { get; set; }
      //  public int DateTime { get; set; }
        public int Unit { get; set; }
        public decimal Price { get; set; }
        public decimal Total_Price { get; set; }
        public int Category_Id { get; set; }
        public int Brand_Id { get; set; }
    }
}
