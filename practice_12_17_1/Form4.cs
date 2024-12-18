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
        private int totalPlay_cnt = 0;
        private int win_cnt = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void isWin(bool myWish)
        {
            textBox1.Text = "";
            int myWish_int = (myWish) ? 1 : 0;

            Random rand = new Random();
            int num_random = rand.Next();
            int divider = 2;
            int remaind = num_random % divider;
            bool result_bool = (myWish_int != remaind) ? false : true;

            // 승리횟수 갱신
            if (result_bool)
            {
                win_cnt++;
            }
            string result = (result_bool) ? "승리" : "패배";
            float winRatio = (float)win_cnt / (float)totalPlay_cnt;

            // 출력부
            StringBuilder sb = new StringBuilder();
            sb.Append($"내 배팅: {myWish_int}\r\n");
            sb.Append($"난수: {num_random}\r\n");
            sb.Append($"divider: {divider}\r\n");
            sb.Append($"동전 던지기 결과: {result}\r\n");
            sb.Append($"플래이 횟수: {totalPlay_cnt}, 승리 횟수: {win_cnt}, 승률: {(float)Math.Round(winRatio * 100, 1)}%\r\n");
            textBox1.Text += sb.ToString();

            
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
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
            // 비어있다면 꺼져
            if(textBox2.Text.Equals("") || textBox2.Text.Equals("please check true or false"))
            {
                textBox2.Text = "please check true or false";
                return;
            }
            totalPlay_cnt++;
            isWin((textBox2.Text.Equals("true")) ? true : false);
        }
    }
}
