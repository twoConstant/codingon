using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace practice_12_17_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
            
        }

        public void isWin(bool myWish)
        {
            textBox1.Text = "";
            int myWish_int = (myWish) ? 1 : 0;

            Random rand = new Random();
            int num_random = rand.Next();
            int divider = 2;
            int remaind = num_random % divider;
            bool result_bool = (myWish_int != remaind) ? false : true;
            string result = (result_bool) ? "승리" : "패배";
            textBox1.Text += "내 배팅: " + myWish_int + "\r\n";
            textBox1.Text += "난수: " + num_random + "\r\n";
            textBox1.Text += "divider: " + divider + "\r\n";
            textBox1.Text += "동전 던지기 결과: " + result + "\r\n";
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            // 입력 박스 초기화
            textBox2.Text = "true";
            textBox1.Text = "";

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "false";
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isWin((textBox2.Text.Equals("true")) ? true : false);
        }
    }
}
