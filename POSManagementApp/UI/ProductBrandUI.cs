using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSManagementApp.BLL;
using POSManagementApp.Model;

namespace POSManagementApp.UI
{
    public partial class ProductBrandUI : Form
    {
        public ProductBrandUI()
        {
            InitializeComponent();
        }
        Manager aManager = new Manager();
        private void brandSaveButton_Click(object sender, EventArgs e)
        {
            Brand aBrand = new Brand();
            aBrand.Name = productBrandTextBox.Text;
           
            if (aManager.SaveBrand(aBrand))
            {
                MessageBox.Show("Product Brand Insert Successfully...");
            }
            productBrandTextBox.Text = "";
        }
    }
}
