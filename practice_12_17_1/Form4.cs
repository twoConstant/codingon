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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            string result = (isWin(true))? "승리" : "패배";
            textBox1.Text = "" + result;
        }

        public bool isWin(bool myWish)
        {
            Random rand = new Random();
            int num_random = rand.Next();
            int divider = 2;
            int result = num_random % divider;

            return result == 1;
        }
    }
}
