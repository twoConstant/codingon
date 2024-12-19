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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 유저의 인풋을 받는다.
            string input = textBox1.Text;

            // 유효성 검사를 한다.
            if(isDay(input))
            {
                Enum.TryParse<Daies>(input, true, out Daies day);
                string outputSentence = getOutPutSentence(day);
                // 출력
                textBox2.Text = outputSentence;

            } else    // 인풋이 유저의 값이 아닐때
            {
                return;
            }
            

        }

        // 유효성 검사
        private Boolean isDay(string input)
        {
            return Enum.TryParse<Daies>(input, true, out Daies day);
        }

        private string getOutPutSentence(Daies day)
        {
            switch (day)
            {
                case Daies.월요일:
                    return "월요병 돋았쥬? 나는 출근 안하쥬? 킹받쥬?.";
                case Daies.화요일:
                    return "일어나 화요일은 하체해야지^^.";
                case Daies.수요일:
                    return "수요일 수요와 공급";
                case Daies.목요일:
                    return "엥? 시간이 멈췄나? 왜 아직 목요일?";
                case Daies.금요일:
                    return "불금 가보자~";
                case Daies.토요일:
                    return "토요일은 토요일";
                case Daies.일요일:
                    return "벌써 일요일이라고?";
                default:
                    return "알 수 없는 요일임";
            }
        }

        private enum Daies
        {
            월요일,
            화요일,
            수요일,
            목요일,
            금요일,
            토요일,
            일요일,
        }
    }
}
