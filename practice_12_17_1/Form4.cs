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
            textBox1.Text = "";
            string result = (isWin(true))? "승리" : "패배";
            textBox1.Text += "동전 던지기 결과: " + result + "\r\n";
        }

        public bool isWin(bool myWish)
        {
            int myWish_int = (myWish) ? 1 : 0;

            Random rand = new Random();
            int num_random = rand.Next();
            int divider = 2;
            int remaind = num_random % divider;
            textBox1.Text += "내 배팅: " + myWish_int + "\r\n";
            textBox1.Text += "난수: " + num_random + "\r\n";
            textBox1.Text += "divider: " + divider + "\r\n";

            return (myWish_int != remaind)? false : true;
        }
    }
}
