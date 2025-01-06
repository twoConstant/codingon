using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_12_17_1
{
    public partial class Form9 : Form
    {
        private BackgroundWorker backgroundWorker;

        public Form9()
        {
            InitializeComponent();

            // BackGroundWorker 초기화 및 이벤트 핸들러 등록
            backgroundWorker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
            };
            backgroundWorker.DoWork += BackgroundWorker_DoWork; // 백그라운드 작업 수행
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged; // 진행 상황 업데이트
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted; // 작업 완료 처리
        }

        private void button_folderpathfinder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // ok 버튼을 누르면
                if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // 선택한 경로를 textbox에 출력
                    textBox_path.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void button_searc_Click(object sender, EventArgs e)
        {
            
            if(!backgroundWorker.IsBusy)
            {
                listBox1.Items.Clear();

                string targetPath = textBox_path.Text;
                string searchPattern = string.Concat("*", textBox_extension.Text);

                backgroundWorker.RunWorkerAsync(new { TargetPath = targetPath, SearchPattern = searchPattern });

                
            }
            

        }
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // 전달받은 경로와 검색 패턴
            dynamic args = e.Argument;
            string targetPath = args.TargetPath;
            string searchPattern = args.SearchPattern;

            // 특정 확장자를 가진 모든 파일 검색
            string[] files = Directory.GetFiles(targetPath, searchPattern, SearchOption.AllDirectories);

            // 검색된 파일 경로를 ProgressChanged로 전달
            foreach (string file in files)
            {
                backgroundWorker.ReportProgress(0, file);
            }
        }

        // ProgressChanged 이벤트: 검색된 파일을 ListBox에 추가
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // 전달된 파일 경로를 ListBox에 추가
            listBox1.Items.Add(e.UserState.ToString());
        }

        // 작업 완료 시 호출
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // 작업 완료 메시지 표시
            MessageBox.Show("Search completed.");
        }

    }
}
