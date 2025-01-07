using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_12_17_1
{
    public partial class Form10 : Form
    {
        private readonly Thread[] threads = new Thread[5];
        private readonly Random random = new Random();
        public Form10()
        {
            InitializeComponent();
            FillThreads();
        }

        private void button_race_start_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < threads.Length; i++)
            {
                threads[i].Start();
            }
        }

        private void FillThreads()
        {
            for(int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(Dowork)
                {
                    Name = $"Thread-{i + 1}" // 스레드 이름 설정
                };
            }
        }

        private void Dowork()
        {
            // 현재 스레드 이름 확인 (디버깅용)
            string threadName = Thread.CurrentThread.Name ?? "Unnamed Thread";

            int distance = 0;
            while (distance < 100)
            {
                distance += 10;
                Thread.Sleep(random.Next(0, 100));
            }

            // UI에 스레드 이름 출력
            Invoke(new Action(() =>
            {
                listBox_results.Items.Add($"{threadName} finished!");
            }));
        }
    }
}
