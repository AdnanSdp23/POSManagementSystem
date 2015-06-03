using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSManagementApp.UI;

namespace POSManagementApp
{
    public partial class AdminUI : Form
    {
        public AdminUI()
        {
            InitializeComponent();
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "admin" && passwordTextBox.Text == "admin")
            {
                ShowProductUI showProductUi = new ShowProductUI();
                showProductUi.Show();
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
            
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

      

    }
}
