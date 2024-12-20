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
    public partial class Form8 : Form
    {
        private readonly Random random = new Random();
        private int totalUserWinCnt = 0;
        private int totalComputerWinCnt = 0;
        private HandSign handsignOfUser;
        private HandSign handsignOfComputer;

        enum HandSign
        {
            ROCK,
            PAPER,
            SCISSORS
        }


        public Form8()
        {
            InitializeComponent();
        }

        // 무승부인가?
        private bool isDraw(HandSign handsignOfUser, HandSign HandsignOfComputer)
        {
            if(handsignOfUser == handsignOfComputer)
            {
                return true;
            }

            // 무승부가 아니라면
            return false;
        }

        // user가 이겼나?
        private bool isUserWin(HandSign handsignOfUser, HandSign HandsignOfComputer)
        {
            switch (handsignOfUser)
            {
                case HandSign.ROCK:
                    return handsignOfComputer == HandSign.SCISSORS; // 바위는 가위를 이김
                case HandSign.PAPER:
                    return handsignOfComputer == HandSign.ROCK;     // 보는 바위를 이김
                case HandSign.SCISSORS:
                    return handsignOfComputer == HandSign.PAPER;    // 가위는 보를 이김
                default:
                    return false; // 정의되지 않은 입력 처리
            }
        }

        // 초기화
        private void setNewGame()
        {
            totalUserWinCnt = 0;
            totalComputerWinCnt = 0;
        }

        // 가위 바위 보 자동 생성기
        private HandSign getRandomOfHandSign()
        {
            return (HandSign)random.Next(0, 3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.handsignOfUser = HandSign.SCISSORS;
            this.handsignOfComputer = getRandomOfHandSign();

            textBox1.Text = "";
            textBox1.Text = $"유저: {handsignOfUser}, 컴퓨터: {handsignOfComputer} \r\n";
            // 무승부인지 확인하기
            if (isDraw(handsignOfUser, handsignOfComputer))
            {
                textBox1.Text += "무승부입니다.";
                textBox1.Text += $"유저: {totalUserWinCnt}, 컴퓨터: {totalComputerWinCnt}";
                return;
            }


            if(isUserWin(handsignOfUser, handsignOfComputer))
            {

                textBox1.Text += "유저의 승리입니다.";
                totalUserWinCnt++;
            } else
            {
                // 컴퓨터가 이긴경우
                textBox1.Text += "유저의 패배입니다.";
                totalComputerWinCnt++;
            }

            textBox1.Text += $"유저: {totalUserWinCnt}, 컴퓨터: {totalComputerWinCnt}";

            // 초기화 판단하기
            if(totalUserWinCnt == 3 || totalComputerWinCnt == 3)
            {
                setNewGame();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.handsignOfUser = HandSign.ROCK;
            this.handsignOfComputer = getRandomOfHandSign();

            textBox1.Text = "";
            textBox1.Text = $"유저: {handsignOfUser}, 컴퓨터: {handsignOfComputer} \r\n";
            // 무승부인지 확인하기
            if (isDraw(handsignOfUser, handsignOfComputer))
            {
                textBox1.Text += "무승부입니다.";
                textBox1.Text += $"유저: {totalUserWinCnt}, 컴퓨터: {totalComputerWinCnt}";
                return;
            }


            if (isUserWin(handsignOfUser, handsignOfComputer))
            {

                textBox1.Text += "유저의 승리입니다.";
                totalUserWinCnt++;
            }
            else
            {
                // 컴퓨터가 이긴경우
                textBox1.Text += "유저의 패배입니다.";
                totalComputerWinCnt++;
            }

            textBox1.Text += $"유저: {totalUserWinCnt}, 컴퓨터: {totalComputerWinCnt}";

            // 초기화 판단하기
            if (totalUserWinCnt == 3 || totalComputerWinCnt == 3)
            {
                setNewGame();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.handsignOfUser = HandSign.PAPER;
            this.handsignOfComputer = getRandomOfHandSign();

            textBox1.Text = "";
            textBox1.Text = $"유저: {handsignOfUser}, 컴퓨터: {handsignOfComputer} \r\n";
            // 무승부인지 확인하기
            if (isDraw(handsignOfUser, handsignOfComputer))
            {
                textBox1.Text += "무승부입니다.";
                textBox1.Text += $"유저: {totalUserWinCnt}, 컴퓨터: {totalComputerWinCnt}";
                return;
            }


            if (isUserWin(handsignOfUser, handsignOfComputer))
            {

                textBox1.Text += "유저의 승리입니다.";
                totalUserWinCnt++;
            }
            else
            {
                // 컴퓨터가 이긴경우
                textBox1.Text += "유저의 패배입니다.";
                totalComputerWinCnt++;
            }

            textBox1.Text += $"유저: {totalUserWinCnt}, 컴퓨터: {totalComputerWinCnt}";

            // 초기화 판단하기
            if (totalUserWinCnt == 3 || totalComputerWinCnt == 3)
            {
                setNewGame();
            }
        }
    }
}
