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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = "";

            // -공자부분 삭제
            string message = "멈추지 않는 함 얼마나 천천히 가는지는 중요하지 않다. -공자";

            // -공자를 삭제
            string keyword = "-공자";
            string message1 = message.Remove(message.IndexOf(keyword), keyword.Length);
            textBox1.Text += message1 + "\r\n";

            // 얼마나, 천천히, 가는지 세개의 단어로 나누어 배열의 요소에 저장
            string[] str_arr = toStringArr(message, "얼마나", "가는지");
            print(str_arr, textBox1);

            string result = method1(message);
            textBox1.Text += result;
        }

        private string[] toStringArr(string message, string str_start, string str_end)
        {
            int idx_start = message.IndexOf(str_start);
            int idx_end = message.IndexOf(str_end) + str_end.Length;
            int str_length = idx_end - idx_start;
            string extractedStr = message.Substring(idx_start, str_length);
            string[] extractedStrToArr = extractedStr.Split();
            return extractedStrToArr;
        }

        private void print(string[] arr, TextBox textBox1)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                textBox1.Text += arr[i] + "\r\n";
            }
        }

        private string method1(string message)
        {
            while (message.IndexOf(".") != -1)
            {
                message = message.Remove(message.IndexOf("."), 1);
            }

            while (message.IndexOf("-") != -1)
            {
                message = message.Remove(message.IndexOf("-"), 1);
            }

            message = message.Replace(" ", ",");
            return message;
        }
    }
}
