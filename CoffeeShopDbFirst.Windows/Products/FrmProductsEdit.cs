using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShopDbFirst.Data;

namespace CoffeeShopDbFirst.Windows.Products
{
    public partial class FrmProductsEdit : Form
    {
        public FrmProductsEdit()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadTypesCombo();
            if (product!=null)
            {
                DescriptionTextBox.Text = product.Description;
                FullPriceTextBox.Text = product.FullPrice.ToString();
                //ProductTypesComboBox.SelectedIndex =
                //    ProductTypesComboBox.FindStringExact(product.ProductType.Description);
                ProductTypesComboBox.SelectedValue = product.ProductTypeId;
            }
        }

        private void LoadTypesCombo()
        {
            List<ProductType> typeList;
            using (var dbContext=new CoffeeShopDbContext())
            {
                typeList = dbContext.ProductTypes
                    .OrderBy(pt=>pt.Description)
                    .ToList();
            }

            ProductType defaultProductType = new ProductType() {Description = "<Select a Type>"};
            typeList.Insert(0,defaultProductType);
            ProductTypesComboBox.DataSource = typeList;
            ProductTypesComboBox.DisplayMember = "Description";
            ProductTypesComboBox.ValueMember = "ProductTypeId";
            ProductTypesComboBox.SelectedIndex = 0;
        }

        private Product product;
        public Product GetProduct()
        {
            return product;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                if (product==null)
                {
                    product = new Product();
                }

                product.Description = DescriptionTextBox.Text;
                product.FullPrice = decimal.Parse(FullPriceTextBox.Text);
                product.ProductTypeId = (int) ProductTypesComboBox.SelectedValue;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidateData()
        {
            bool isValid = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(DescriptionTextBox.Text))
            {
                isValid = false;
                errorProvider1.SetError(DescriptionTextBox,"You must enter a description");
            }

            if (ProductTypesComboBox.SelectedIndex==0)
            {
                isValid = false;
                errorProvider1.SetError(ProductTypesComboBox,"You must select a type");
            }

            if (!decimal.TryParse(FullPriceTextBox.Text, out decimal price))
            {
                isValid = false;
                errorProvider1.SetError(FullPriceTextBox,"You must enter a valid price");
            }
            else if (price<=0 ||price>10000)
            {
                isValid = false;
                errorProvider1.SetError(FullPriceTextBox,"Price must be between 1 and 10000");
            }

            return isValid;
        }

        public void SetProduct(Product updateProduct)
        {
            product = updateProduct;
        }
    }
}
