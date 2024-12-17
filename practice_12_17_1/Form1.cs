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
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 문자열 변수 선언
            string str1 = "동해 물과 백두산이";
            string str2 = "토요일에 먹는 토마토";
            string str3 = "질서있는 퇴장";
            string str4 = "그 사람의 그림자는 그랬다.";
            string str5 = "삼성 갤럭시";
            string str6 = "오늘은 왠지 더 배고프다";
            string str7 = "이름,나이,전화번호";
            string str8 = "우리 나라 만세";

            // 결과를 저장할 문자열 배열
            string[] results = new string[10];

            // 결과 계산
            results[0] = str1.IndexOf("백두산").ToString();
            results[1] = str2.LastIndexOf("토").ToString();
            results[2] = str3.Contains("퇴").ToString();
            results[3] = str4.Replace("그", "이");
            results[4] = str5.Insert(3, "애플 ");
            results[5] = str6.Remove(str6.IndexOf('더'), 1);
            string[] splitResult = str7.Split(',');
            results[6] = splitResult[0];
            results[7] = splitResult[1];
            results[8] = splitResult[2];
            results[9] = str8.Substring(3, 2);
            InitializeComponent();

            for(int i = 0; i < results.Length; i++)
            {
                textBox1.Text += results[i] + "\r\n";
            }
            
        }
    }
}
