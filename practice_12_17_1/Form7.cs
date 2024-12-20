using System;
using System.CodeDom;
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
        private readonly Random rnd = new Random();

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 유효성 검사
            if(!(int.TryParse(textBox1.Text, out int inputNumOfStudent) && inputNumOfStudent >= 0))
            {
                // 숫자가 아닌경우와 0 이하의 숫자를 입력한 경우
                return;
            }

            int[] studentScore_arr = generateStudentScoreArr(inputNumOfStudent);
            string strToPrint = makeStrToPrint(studentScore_arr);
            textBox2.Text = strToPrint;
        }

        private int[] generateStudentScoreArr(int num)
        {
            int[] scoreArr = new int[num];
            for(int i = 0; i < num; i++)
            {
                scoreArr[i] = rnd.Next(0, 101);    // rnd : 멤버변수로 선언
            }
            return scoreArr;
        }

        private string makeStrToPrint(int[] studentScore_arr)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < studentScore_arr.Length; i++)
            {
                sb.Append($"student{i + 1} score: {studentScore_arr[i]} \r\n");
            }
            return sb.ToString();
        }
    }
}
