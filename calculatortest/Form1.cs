using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatortest
{
    public partial class Form1 : Form
    {
        Calculators calculators = new Calculators();
        public Form1()
        {
            InitializeComponent();
            
        }

        // 더하기
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = calculators.GetLatestFormula(textBox2.Text, "+");
            textBox2.Text = calculators.GetCurrentDouble();
        }

        // 빼기
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = calculators.GetLatestFormula(textBox2.Text, "-");
            textBox2.Text = calculators.GetCurrentDouble();
        }

        // 나누기
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = calculators.GetLatestFormula(textBox2.Text, "÷");
            textBox2.Text = calculators.GetCurrentDouble();
        }

        // 곱하기
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = calculators.GetLatestFormula(textBox2.Text, "×");
            textBox2.Text = calculators.GetCurrentDouble();
        }

        // 등호
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = calculators.SubmitAndGetResult(textBox2.Text);
            textBox2.Text = calculators.GetCurrentDouble();
        }
    }
}
