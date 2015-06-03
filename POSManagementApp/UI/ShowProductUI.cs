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
    public partial class ShowProductUI : Form
    {
        Manager manager=new Manager();
        public ShowProductUI()
        {
            InitializeComponent();
        }
        List<AllProducts> allProducts=new List<AllProducts>();
        private void ShowProductUI_Load(object sender, EventArgs e)
        {
            LoadAllProducts();
        }

        private void LoadAllProducts()
        {
            allProducts = manager.AllProducts();
            showProductListView.Items.Clear();
            foreach (var products in allProducts)
            {
                ListViewItem item = new ListViewItem(products.SerialNo.ToString());
                item.SubItems.Add(products.ProductCategory);
                item.SubItems.Add(products.ProductBrand);
                item.SubItems.Add(products.TotalNumberOfUnit.ToString());
                showProductListView.Items.Add(item);
            }

           
        }

        private void addProductsButton_Click(object sender, EventArgs e)
        {
            AddProductUI addProductUi = new AddProductUI();
            addProductUi.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadAllProducts();
        }
    }
}
