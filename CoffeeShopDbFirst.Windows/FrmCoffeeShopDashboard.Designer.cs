
namespace CoffeeShopDbFirst.Windows
{
    partial class FrmCoffeeShopDashboard
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ManageProductsButton = new System.Windows.Forms.Button();
            this.ManageProductTypesButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SalesButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ManageProductsButton);
            this.groupBox1.Controls.Add(this.ManageProductTypesButton);
            this.groupBox1.Location = new System.Drawing.Point(28, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Manage Stock ";
            // 
            // ManageProductsButton
            // 
            this.ManageProductsButton.Location = new System.Drawing.Point(18, 106);
            this.ManageProductsButton.Name = "ManageProductsButton";
            this.ManageProductsButton.Size = new System.Drawing.Size(190, 61);
            this.ManageProductsButton.TabIndex = 0;
            this.ManageProductsButton.Text = "Manage Products";
            this.ManageProductsButton.UseVisualStyleBackColor = true;
            // 
            // ManageProductTypesButton
            // 
            this.ManageProductTypesButton.Location = new System.Drawing.Point(18, 30);
            this.ManageProductTypesButton.Name = "ManageProductTypesButton";
            this.ManageProductTypesButton.Size = new System.Drawing.Size(190, 61);
            this.ManageProductTypesButton.TabIndex = 0;
            this.ManageProductTypesButton.Text = "Manage Product Types";
            this.ManageProductTypesButton.UseVisualStyleBackColor = true;
            this.ManageProductTypesButton.Click += new System.EventHandler(this.ManageProductTypesButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SalesButton);
            this.groupBox2.Location = new System.Drawing.Point(307, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 188);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Manage Sales ";
            // 
            // SalesButton
            // 
            this.SalesButton.Location = new System.Drawing.Point(18, 30);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(190, 61);
            this.SalesButton.TabIndex = 0;
            this.SalesButton.Text = "Sales";
            this.SalesButton.UseVisualStyleBackColor = true;
            // 
            // FrmCoffeeShopDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 260);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCoffeeShopDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Shop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ManageProductsButton;
        private System.Windows.Forms.Button ManageProductTypesButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SalesButton;
    }
}

