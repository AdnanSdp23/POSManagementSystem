namespace POSManagementApp.UI
{
    partial class ProductCategoryUI
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
            this.productCategoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categorySaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productCategoryTextBox
            // 
            this.productCategoryTextBox.Location = new System.Drawing.Point(154, 76);
            this.productCategoryTextBox.Name = "productCategoryTextBox";
            this.productCategoryTextBox.Size = new System.Drawing.Size(135, 20);
            this.productCategoryTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Category :";
            // 
            // categorySaveButton
            // 
            this.categorySaveButton.Location = new System.Drawing.Point(214, 112);
            this.categorySaveButton.Name = "categorySaveButton";
            this.categorySaveButton.Size = new System.Drawing.Size(75, 23);
            this.categorySaveButton.TabIndex = 2;
            this.categorySaveButton.Text = "Save";
            this.categorySaveButton.UseVisualStyleBackColor = true;
            this.categorySaveButton.Click += new System.EventHandler(this.categorySaveButton_Click);
            // 
            // ProductCategoryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(301, 162);
            this.Controls.Add(this.categorySaveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productCategoryTextBox);
            this.Name = "ProductCategoryUI";
            this.Text = "ProductCategoryUI";
            this.Load += new System.EventHandler(this.ProductCategoryUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productCategoryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button categorySaveButton;
    }
}