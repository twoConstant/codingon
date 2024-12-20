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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputNumOfStudent_str = textBox1.Text;
            int[] studentScore_arr = generateStudentScoreArr(int.Parse(inputNumOfStudent_str));
            string strToPrint = makeStrToPrint(studentScore_arr);
            textBox2.Text = strToPrint;
        }

        private int[] generateStudentScoreArr(int num)
        {
            Random rnd = new Random();
            int[] scoreArr = new int[num];
            for(int i = 0; i < num; i++)
            {
                scoreArr[i] = rnd.Next(0, 101);
            }
            return scoreArr;
        }

        private string makeStrToPrint(int[] studentScore_arr)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < studentScore_arr.Length; i++)
            {
                sb.Append("student" + i + " score: " + studentScore_arr[i] + "\r\n");
            }
            return sb.ToString();
        }
    }
}
