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
    public partial class AddProductUI : Form
    {
        CategoryManager aCategoryManager = new CategoryManager();
        BrandManager aBrandManager = new BrandManager();
        public AddProductUI()
        {
            InitializeComponent();
        }

        private void AddProductUI_Load(object sender, EventArgs e)
        {
            LoadAllProducts();
           
        }

        private void LoadAllProducts()
        {
            LoadAllCategoryInComboBox();
            LoadAllBrandInComboBox();
        }

        private void LoadAllBrandInComboBox()
        {

            List<Brand> brands = aBrandManager.GetAllBrands();
            brandComboBox.DisplayMember = "Name";
            brandComboBox.ValueMember = "Id";
            brandComboBox.DataSource = null;
            brandComboBox.DataSource = brands;
        }

        private void LoadAllCategoryInComboBox()
        {
           
            List<Category> categories = aCategoryManager.GetAllCategories();
            categoriesComboBox.DisplayMember = "Name";
            categoriesComboBox.ValueMember = "Id";
               
            categoriesComboBox.DataSource = null;
            categoriesComboBox.DataSource = categories;
        }

        private void addMoreCategoryButton_Click(object sender, EventArgs e)
        {
            ProductCategoryUI productCategoryUi = new ProductCategoryUI();
            productCategoryUi.Show();
        }

        private void addMoreBrandButton_Click(object sender, EventArgs e)
        {
            ProductBrandUI productBrandUi = new ProductBrandUI();
            productBrandUi.Show();
        }
        Manager aManager = new Manager();
        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            product aProduct = new product();
           // aProduct.Purchase_No = purchaseNoTextBox.Text;
           // aProduct.DateTime = Convert.ToInt16(purchasedateTimePicker.Text);
            aProduct.Unit = Convert.ToInt32(unitTextBox.Text);
            aProduct.Price = Convert.ToDecimal(priceTextBox.Text);


            aProduct.Total_Price = aManager.TotalAmount(aProduct);
            aProduct.Category_Id = Convert.ToInt32(categoriesComboBox.SelectedValue.ToString());
            aProduct.Brand_Id = Convert.ToInt32(brandComboBox.SelectedValue.ToString());
            if (aManager.SaveProduct(aProduct))
            {
                MessageBox.Show("Product insert Successfully!!!");
            }
           // categoriesComboBox.Text = "";
           // brandComboBox.Text = "";
            unitTextBox.Text = "";
            priceTextBox.Text = "";
           // purchaseNoTextBox.Text = "";

        }

        private void totalPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void productAddRefreshButton_Click(object sender, EventArgs e)
        {
            

            AddProductUI addProductUi = new AddProductUI();
            addProductUi.Show();
            this.Close();
        }
    }
}
