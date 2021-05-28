using System;
using System.Windows.Forms;
using CoffeeShopDbFirst.Windows.ProductTypes;

namespace CoffeeShopDbFirst.Windows
{
    public partial class FrmCoffeeShopDashboard : Form
    {
        public FrmCoffeeShopDashboard()
        {
            InitializeComponent();
        }

        private void ManageProductTypesButton_Click(object sender, EventArgs e)
        {
            FrmManageProductTypes frm = new FrmManageProductTypes {Text = @"Manage Product Types"};
            frm.ShowDialog(this);
        }
    }
}
