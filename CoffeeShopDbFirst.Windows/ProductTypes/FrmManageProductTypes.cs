using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using CoffeeShopDbFirst.Data;

namespace CoffeeShopDbFirst.Windows.ProductTypes
{
    public partial class FrmManageProductTypes : Form
    {
        public FrmManageProductTypes()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
        }

        private void FrmManageProductTypes_Load(object sender, EventArgs e)
        {
            LoadProductTypes();
        }

        private List<ProductType> productTypes;
        private void LoadProductTypes()
        {
            
            using (var dbContext=new CoffeeShopDbContext())
            {
                productTypes = dbContext.ProductTypes.AsNoTracking().ToList();

            }

            DisplayProductTypesData();
            if (productTypes.Count==0)
            {
                ManageButtons(true);
                return;
            }
            ManageButtons(false);

        }

        private void DisplayProductTypesData()
        {
            TypesDataGridView.Rows.Clear();
            foreach (var productType in productTypes)
            {
                DataGridViewRow r = BuildRow();
                SetRow(r, productType);
                AddRow(r);
            }
        }

        private void AddRow(DataGridViewRow r)
        {
            TypesDataGridView.Rows.Add(r);
        }

        private void SetRow(DataGridViewRow r, ProductType productType)
        {
            r.Cells[colProductType.Index].Value = productType.Description;
            r.Cells[colDetails.Index].Value = productType.Details;

            r.Tag = productType;
        }

        private DataGridViewRow BuildRow()
        {
            var r = new DataGridViewRow();
            r.CreateCells(TypesDataGridView);
            return r;
        }

        private ProductType productType;
        private void TypesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (TypesDataGridView.SelectedRows.Count==0)
            {
                return;
                
            }

            r = TypesDataGridView.SelectedRows[0];
            productType = (ProductType) r.Tag;
            DisplayProductType(productType);
        }

        private void DisplayProductType(ProductType productType)
        {
            productTypeIdLabel.Text = productType.ProductTypeId.ToString();
            DescriptionTextBox.Text = productType.Description;
            DetailsTextBox.Text = productType.Details;

        }

        private void ManageButtons(bool enabled)
        {
            NewButton.Enabled = enabled;
            DeleteButton.Enabled = !enabled;
            UpdateButton.Enabled = !enabled;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearControls();
            ManageButtons(true);
            productType = null;
        }

        private void ClearControls()
        {
            productTypeIdLabel.Text = "0";
            DescriptionTextBox.Clear();
            DetailsTextBox.Clear();

            DescriptionTextBox.Focus();
        }

        private DataGridViewRow r;
        private void NewButton_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                productType = new ProductType()
                {
                    Description = DescriptionTextBox.Text,
                    Details = DetailsTextBox.Text
                };

                try
                {
                    using (var dbContext=new CoffeeShopDbContext())
                    {
                        dbContext.ProductTypes.Add(productType);
                        dbContext.SaveChanges();
                    }
                    LoadProductTypes();
                    MessageBox.Show(@"Record Added Successfully!!", "Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ManageButtons(false);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private bool ValidateData()
        {
            bool IsValid = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(DescriptionTextBox.Text))
            {
                IsValid = false;
                errorProvider1.SetError(DescriptionTextBox,"You must enter a description");
            }

            return IsValid;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dbContext = new CoffeeShopDbContext())
                {
                    dbContext.Entry(productType).State = EntityState.Deleted;
                    dbContext.ProductTypes.Remove(productType);
                    dbContext.SaveChanges();
                }
                LoadProductTypes();
                MessageBox.Show(@"Record Deleted Successfully!!", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                productType.Description = DescriptionTextBox.Text;
                productType.Details = DetailsTextBox.Text;
                try
                {
                    using (var dbContext=new CoffeeShopDbContext())
                    {
                        dbContext.Entry(productType).State = EntityState.Modified;
                        dbContext.SaveChanges();
                    }
                    LoadProductTypes();
                    MessageBox.Show(@"Record Deleted Successfully!!", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    using (var dbContext=new CoffeeShopDbContext())
                    {
                        productType = dbContext.ProductTypes
                            .SingleOrDefault(pt => pt.ProductTypeId == productType.ProductTypeId);
                    }
                    DisplayProductType(productType);
                    SetRow(r,productType);
                }
            }
        }
    }
}
