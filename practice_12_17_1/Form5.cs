using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_12_17_1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            textBox_result.Text = "";
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            textBox_result.Text += textBox_input.Text + "\r\n";
            textBox_input.Text = "";
        }

    }
}
