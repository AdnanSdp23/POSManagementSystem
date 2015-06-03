namespace POSManagementApp.UI
{
    partial class ShowProductUI
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
            this.addProductsButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.showProductListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addProductsButton
            // 
            this.addProductsButton.Location = new System.Drawing.Point(136, 12);
            this.addProductsButton.Name = "addProductsButton";
            this.addProductsButton.Size = new System.Drawing.Size(89, 23);
            this.addProductsButton.TabIndex = 0;
            this.addProductsButton.Text = "Add Products";
            this.addProductsButton.UseVisualStyleBackColor = true;
            this.addProductsButton.Click += new System.EventHandler(this.addProductsButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Available Product :";
            // 
            // showProductListView
            // 
            this.showProductListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6});
            this.showProductListView.GridLines = true;
            this.showProductListView.Location = new System.Drawing.Point(12, 94);
            this.showProductListView.Name = "showProductListView";
            this.showProductListView.Size = new System.Drawing.Size(402, 185);
            this.showProductListView.TabIndex = 3;
            this.showProductListView.UseCompatibleStateImageBehavior = false;
            this.showProductListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Purchase_No";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Category";
            this.columnHeader2.Width = 114;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Product Brand";
            this.columnHeader5.Width = 89;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total No. of Unit";
            this.columnHeader6.Width = 106;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(339, 290);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh ";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // ShowProductUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 325);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.showProductListView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addProductsButton);
            this.Name = "ShowProductUI";
            this.Text = "ShowProductUI";
            this.Load += new System.EventHandler(this.ShowProductUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addProductsButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView showProductListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}