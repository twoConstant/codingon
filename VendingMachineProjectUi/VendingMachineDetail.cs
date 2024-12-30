using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendingMachingProject.transaction_manager;
using VendingMachingProject.User;
using VendingMachingProject.vendingmaching;

namespace VendingMachineProjectUi
{
    public partial class VendingMachineDetail : Form
    {
        private IVendingMachine vm;
        private IUser user;
        private ITransactionManager tm;
        private int price;

        public VendingMachineDetail(IVendingMachine vm, IUser user, ITransactionManager tm)
        {
            InitializeComponent();
            InitVendingMachineDetail(vm, user, tm);
        }

        private void InitVendingMachineDetail(IVendingMachine vm, IUser user, ITransactionManager tm)
        {
            this.vm = vm;
            this.user = user;
            this.tm = tm;
            this.price = vm.GetPrice();

            // textBox 초기화
            textBox_title.Text = vm.GetName();
            textBox_stock.Text = vm.GetStock().ToString();
            textBox_price.Text = vm.GetPrice().ToString();

            // 유저 상태
            textBox_balance.Text = tm.GetBalance(user.GetRandomDepositeId()).ToString();
            textBox_creditcarde_accprice.Text = tm.GetCreditCardAccPrice(user.GetRandomCreditCardId()).ToString();
            textBox_limit.Text = tm.GetCreditCardLimit(user.GetRandomCreditCardId()).ToString();

        }

        private void textBox_buy_quantity_TextChanged(object sender, EventArgs e)
        {
            int orderQuantity = int.Parse(textBox_buy_quantity.Text);
            textBox_total_price.Text = (price * orderQuantity).ToString();
        }

        private void button_buy_Click(object sender, EventArgs e)
        {
            if (radioButton_creditCard.Checked)
            {
                user.BuyDrink(user.GetRandomCreditCardId(), int.Parse(textBox_buy_quantity.Text));
            } else if (radioButton_deposite.Checked)
            {
                user.BuyDrink(user.GetRandomDepositeId(), int.Parse(textBox_buy_quantity.Text));
            }
            InitVendingMachineDetail(vm, user, tm);
        }
    }
}
