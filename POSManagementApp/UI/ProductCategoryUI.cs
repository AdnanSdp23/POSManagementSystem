using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSManagementApp.Model;
using POSManagementApp.BLL;


namespace POSManagementApp.UI
{
    public partial class ProductCategoryUI : Form
    {
        public ProductCategoryUI()
        {
            InitializeComponent();
        }
        Manager aManager = new Manager();
        private void categorySaveButton_Click(object sender, EventArgs e)
        {
            Category aCategory = new Category();
            aCategory.Name=productCategoryTextBox.Text;
            if(aManager.SaveGategory(aCategory))
            {
                MessageBox.Show("Product Category Insert Successfully...");
            }
            productCategoryTextBox.Text = "";
        }

        private void ProductCategoryUI_Load(object sender, EventArgs e)
        {

        }
    }
}
