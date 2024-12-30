using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineProjectUi
{
    public partial class InstallVendingMachineForm : Form
    {
        public string vendingmachineName { get; private set; }
        public int drinkPrice { get; private set; }
        public InstallVendingMachineForm()
        {
            InitializeComponent();
            textBox_drink_price.Text = string.Empty;
            textBox_vendingmachine_name.Text = string.Empty;
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            vendingmachineName = textBox_vendingmachine_name.Text;
            int.TryParse(textBox_drink_price.Text,out int price);
            drinkPrice = price;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
