using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            string threadName = Thread.CurrentThread.Name ?? "Unnamed Thread";

            Stopwatch stopwatch = Stopwatch.StartNew();

            int distance = 0;
            while (distance < 100)
            {
                distance += 10;
                Thread.Sleep(random.Next(0, 100));
            }

            // Stopwatch 정지 및 실행 시간 계산
            stopwatch.Stop();
            double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;

            // UI에 스레드 이름과 실행 시간 출력
            Invoke(new Action(() =>
            {
                listBox_results.Items.Add($"{threadName} finished in {elapsedSeconds:F2} seconds!");
            }));
        }
    }
}
