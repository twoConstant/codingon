using System.CodeDom;
using System.Transactions;
using VendingMachingProject;
using VendingMachingProject.transaction_manager;
using VendingMachingProject.User;
using VendingMachingProject.users;
using VendingMachingProject.vendingmaching;
using VendingMachingProject.vendingmaching_manager;

namespace VendingMachineProjectUi
{
    public partial class Form1 : Form
    {
        private IVendingMachineManager vmm;
        private ITransactionManager tm;
        public Form1()
        {
            InitializeComponent();
            InitializeManager();
        }

        private void InitializeManager()
        {
            this.tm = new TransactionManagerV1();
            this.vmm = new VendingMachineManagerV1(tm);
            textBox_total_sales.Text = vmm.GetTotalSale().ToString();
        }

        private void button_installation_Click(object sender, EventArgs e)
        {
            // �˾�â ����
            using (InstallVendingMachineForm installVendingMachineForm = new InstallVendingMachineForm())
            {
                // ����ڰ� �˾������� Ȯ���� ��������
                if (installVendingMachineForm.ShowDialog() == DialogResult.OK)
                {
                    string vendingMachineName = installVendingMachineForm.vendingmachineName;
                    int price = installVendingMachineForm.drinkPrice;
                    vmm.CreateVendingMachineV1AndAdd(vendingMachineName, price);
                    Console.WriteLine("���� �Ϸ�");
                }
            }


        }

        private void button_fill_listBox_Click(object sender, EventArgs e)
        {

            // ������ � ������ �Ǿ��ִ°��� ���� ListBox�� ������ ä����
            List<string> names = new List<string>();
            if (radioButton_get_all.Checked)
            {
                names = vmm.GetVendingMachineNames();

            }
            else if (radioButton_repaire.Checked)
            {
                names = vmm.GetVendingMachinesNeedingRepair(6);

            }
            else if (radioButton_replace.Checked)
            {
                // �ֱ� ������ �Է�
                names = vmm.GetVendingMachinesNeedingReplacement(2);

            }
            else if (radioButton_filling_need.Checked)
            {
                names = vmm.GetVendingMachinesWithStockBelow(10);
            }

            // ���� �׸� �ʱ�ȭ
            listBox_vendingmachine_names.Items.Clear();
            foreach (string name in names)
            {
                listBox_vendingmachine_names.Items.Add(name);
            }

            textBox_total_sales.Text = vmm.GetTotalSale().ToString();
        }

        private void listBox_vendingmachine_names_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox_vendingmachine_names.SelectedItem.ToString();
            textBox_selected_item.Text = selectedItem;
        }

        private void textBox_selected_item_TextChanged(object sender, EventArgs e)
        {
            IVendingMachine vm = vmm.GetVendingMachineByName(textBox_selected_item.Text);
            textBox_date_Installation.Text = vm.GetCreateDate().ToShortDateString();
            textBox_date_last_repair.Text = vm.GetlastRepairDate().ToShortDateString();
            textBox_sales.Text = vm.GetTotalSales().ToString();
            textBox_stock.Text = vm.GetStock().ToString();

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string name = textBox_selected_item.Text;
            vmm.RemoveVendingMachineByName(name);
        }

        private void button_filling_Click(object sender, EventArgs e)
        {
            vmm.FillVendingMachine(textBox_selected_item.Text, 10);
        }

        private void button_fillings_Click(object sender, EventArgs e)
        {
            vmm.FillVendingMachines(10, 50);
        }

        private void button_vending_machine_detail_Click(object sender, EventArgs e)
        {
            string selectedVendingMachineName = textBox_selected_item.Text;

            IVendingMachine selectedVendingMachine = vmm.GetVendingMachineByName(selectedVendingMachineName);

            // ���ο� user ��ü ����
            IUser newUser = new UserV1(this.tm, selectedVendingMachine, 500000, 500000);
            VendingMachineDetail detailForm = new VendingMachineDetail(selectedVendingMachine, newUser, tm);
            detailForm.Show();
        }
    }
}