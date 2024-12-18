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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            int num = 2345123;
            int div = 231;
            int[] result = getSharAndRemain(num, div);

            textBox1.Text = "";
            for(int i = 0; i < result.Length; i++)
            {
                textBox1.Text += result[i] + " ";
            }
        }

        public int[] getSharAndRemain(int num, int div)
        {
            // 배열 생성
            int[] result_arr = new int[2];
            int share = num / div;
            int remain = num % div;
            result_arr[0] = share;
            result_arr[1] = remain;

            return result_arr;
        }
    }
}
