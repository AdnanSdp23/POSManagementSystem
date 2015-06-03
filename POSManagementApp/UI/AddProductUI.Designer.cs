namespace POSManagementApp.UI
{
    partial class AddProductUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.addProductSaveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.addMoreCategoryButton = new System.Windows.Forms.Button();
            this.addMoreBrandButton = new System.Windows.Forms.Button();
            this.productAddRefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Category :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Brand :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Unit :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price :";
            // 
            // unitTextBox
            // 
            this.unitTextBox.Location = new System.Drawing.Point(153, 165);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(121, 20);
            this.unitTextBox.TabIndex = 10;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(153, 206);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(121, 20);
            this.priceTextBox.TabIndex = 11;
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Location = new System.Drawing.Point(153, 72);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoriesComboBox.TabIndex = 8;
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(153, 121);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(121, 21);
            this.brandComboBox.TabIndex = 9;
            // 
            // addProductSaveButton
            // 
            this.addProductSaveButton.Location = new System.Drawing.Point(199, 246);
            this.addProductSaveButton.Name = "addProductSaveButton";
            this.addProductSaveButton.Size = new System.Drawing.Size(75, 23);
            this.addProductSaveButton.TabIndex = 15;
            this.addProductSaveButton.Text = "Save";
            this.addProductSaveButton.UseVisualStyleBackColor = true;
            this.addProductSaveButton.Click += new System.EventHandler(this.addProductSaveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tk.";
            // 
            // addMoreCategoryButton
            // 
            this.addMoreCategoryButton.Location = new System.Drawing.Point(283, 72);
            this.addMoreCategoryButton.Name = "addMoreCategoryButton";
            this.addMoreCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.addMoreCategoryButton.TabIndex = 12;
            this.addMoreCategoryButton.Text = "Add More..";
            this.addMoreCategoryButton.UseVisualStyleBackColor = true;
            this.addMoreCategoryButton.Click += new System.EventHandler(this.addMoreCategoryButton_Click);
            // 
            // addMoreBrandButton
            // 
            this.addMoreBrandButton.Location = new System.Drawing.Point(283, 121);
            this.addMoreBrandButton.Name = "addMoreBrandButton";
            this.addMoreBrandButton.Size = new System.Drawing.Size(75, 23);
            this.addMoreBrandButton.TabIndex = 13;
            this.addMoreBrandButton.Text = "Add More..";
            this.addMoreBrandButton.UseVisualStyleBackColor = true;
            this.addMoreBrandButton.Click += new System.EventHandler(this.addMoreBrandButton_Click);
            // 
            // productAddRefreshButton
            // 
            this.productAddRefreshButton.Location = new System.Drawing.Point(294, 246);
            this.productAddRefreshButton.Name = "productAddRefreshButton";
            this.productAddRefreshButton.Size = new System.Drawing.Size(75, 23);
            this.productAddRefreshButton.TabIndex = 16;
            this.productAddRefreshButton.Text = "Refresh";
            this.productAddRefreshButton.UseVisualStyleBackColor = true;
            this.productAddRefreshButton.Click += new System.EventHandler(this.productAddRefreshButton_Click);
            // 
            // AddProductUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 310);
            this.Controls.Add(this.productAddRefreshButton);
            this.Controls.Add(this.addMoreBrandButton);
            this.Controls.Add(this.addMoreCategoryButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addProductSaveButton);
            this.Controls.Add(this.brandComboBox);
            this.Controls.Add(this.categoriesComboBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProductUI";
            this.Text = "AddProductUI";
            this.Load += new System.EventHandler(this.AddProductUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox categoriesComboBox;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.Button addProductSaveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addMoreCategoryButton;
        private System.Windows.Forms.Button addMoreBrandButton;
        private System.Windows.Forms.Button productAddRefreshButton;
    }
}