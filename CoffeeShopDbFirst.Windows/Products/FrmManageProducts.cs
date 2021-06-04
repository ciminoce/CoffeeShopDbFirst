using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShopDbFirst.Data;

namespace CoffeeShopDbFirst.Windows.Products
{
    public partial class FrmManageProducts : Form
    {
        public FrmManageProducts()
        {
            InitializeComponent();
        }

        private void FrmManageProducts_Load(object sender, EventArgs e)
        {
            List<Product> productList;
            using (var dbContext = new CoffeeShopDbContext())
            {
                productList = dbContext.Products
                    .Include(p => p.ProductType)
                    .AsNoTracking()
                    .ToList();
            }

            ShowDataInGrid(productList);
        }

        private void ShowDataInGrid(List<Product> productList)
        {
            ProductsDataGridView.Rows.Clear();
            foreach (var product in productList)
            {
                DataGridViewRow r = BuildRow();
                SetRow(r, product);
                AddRow(r);
            }
        }

        private void AddRow(DataGridViewRow r)
        {
            ProductsDataGridView.Rows.Add(r);
        }

        private void SetRow(DataGridViewRow r, Product product)
        {
            r.Cells[colProduct.Index].Value = product.Description;
            r.Cells[colType.Index].Value = product.ProductType.Description;
            r.Cells[colPrice.Index].Value = product.FullPrice;

            r.Tag = product;
        }

        private DataGridViewRow BuildRow()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(ProductsDataGridView);
            return r;

        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            FrmProductsEdit frm = new FrmProductsEdit() { Text = "Add New Product" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Product newProduct = frm.GetProduct();
                    using (var dbContext = new CoffeeShopDbContext())
                    {
                        if (dbContext.Products.Any(p => p.Description == newProduct.Description &&
                                                      p.ProductTypeId == newProduct.ProductTypeId))
                        {
                            MessageBox.Show("Product already exist", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }

                        dbContext.Products.Add(newProduct);
                        dbContext.SaveChanges();
                        newProduct.ProductType = dbContext.ProductTypes
                            .SingleOrDefault(pt => pt.ProductTypeId == newProduct.ProductTypeId);
                    }

                    MessageBox.Show("Record Added Successfully", "Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    DataGridViewRow r = BuildRow();
                    SetRow(r, newProduct);
                    AddRow(r);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (ProductsDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = ProductsDataGridView.SelectedRows[0];
            Product deleteProduct = (Product)r.Tag;
            DialogResult dr = MessageBox.Show($"Are you sure to delete {deleteProduct.Description}?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                //TODO:Ver si el registro no está relacionado
                using (var dbContext = new CoffeeShopDbContext())
                {
                    dbContext.Entry(deleteProduct).State = EntityState.Deleted;
                    dbContext.SaveChanges();
                }

                MessageBox.Show("Record Deleted Successfully!!", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ProductsDataGridView.Rows.Remove(r);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void UpdateToolStripButton_Click(object sender, EventArgs e)
        {
            if (ProductsDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = ProductsDataGridView.SelectedRows[0];
            Product updateProduct = (Product)r.Tag;
            FrmProductsEdit frm = new FrmProductsEdit() { Text = "Update Product" };
            frm.SetProduct(updateProduct);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    updateProduct = frm.GetProduct();
                    using (var dbContext = new CoffeeShopDbContext())
                    {
                        updateProduct.ProductType =
                           dbContext.ProductTypes.SingleOrDefault(
                               pt => pt.ProductTypeId == updateProduct.ProductTypeId);
                        if (dbContext.Products.Any(p => p.Description == updateProduct.Description &&
                                                       p.ProductTypeId == updateProduct.ProductTypeId))
                        {
                            MessageBox.Show("Product already exist", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                            dbContext.Products.Attach(updateProduct);
                            dbContext.Entry(updateProduct).Reload();

                            SetRow(r, updateProduct);

                            return;



                        }

                        dbContext.Entry(updateProduct).State = EntityState.Modified;

                        dbContext.SaveChanges();
                    }
                    SetRow(r, updateProduct);
                    MessageBox.Show("Record Updated Successfully!!", "Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    using (var dbContext=new CoffeeShopDbContext())
                    {
                        dbContext.Products.Attach(updateProduct);
                        dbContext.Entry(updateProduct).Reload();

                        SetRow(r, updateProduct);

                    }
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
