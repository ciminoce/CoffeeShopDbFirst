
namespace CoffeeShopDbFirst.Windows.Products
{
    partial class FrmProducts
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UpdateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripButton,
            this.DeleteToolStripButton,
            this.UpdateToolStripButton,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(924, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewToolStripButton
            // 
            this.NewToolStripButton.Image = global::CoffeeShopDbFirst.Windows.Properties.Resources.new_copy_40px;
            this.NewToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStripButton.Name = "NewToolStripButton";
            this.NewToolStripButton.Size = new System.Drawing.Size(44, 59);
            this.NewToolStripButton.Text = "New";
            this.NewToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.Image = global::CoffeeShopDbFirst.Windows.Properties.Resources.delete_document_40px;
            this.DeleteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Size = new System.Drawing.Size(44, 59);
            this.DeleteToolStripButton.Text = "Delete";
            this.DeleteToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // UpdateToolStripButton
            // 
            this.UpdateToolStripButton.Image = global::CoffeeShopDbFirst.Windows.Properties.Resources.edit_property_40px;
            this.UpdateToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UpdateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateToolStripButton.Name = "UpdateToolStripButton";
            this.UpdateToolStripButton.Size = new System.Drawing.Size(49, 59);
            this.UpdateToolStripButton.Text = "Update";
            this.UpdateToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProductsDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 451);
            this.panel1.TabIndex = 1;
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.AllowUserToAddRows = false;
            this.ProductsDataGridView.AllowUserToDeleteRows = false;
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProduct,
            this.colType,
            this.colPrice});
            this.ProductsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ProductsDataGridView.MultiSelect = false;
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.ReadOnly = true;
            this.ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDataGridView.Size = new System.Drawing.Size(924, 451);
            this.ProductsDataGridView.TabIndex = 0;
            // 
            // colProduct
            // 
            this.colProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProduct.HeaderText = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colType.HeaderText = "Product Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 56;
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmProducts";
            this.Text = "FrmProducts";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewToolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        private System.Windows.Forms.ToolStripButton UpdateToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    }
}