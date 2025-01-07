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
    public partial class Form11 : Form
    {
        
        public Form11()
        {
            InitializeComponent();
        }

        private void button_file_finder_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*", // .txt 파일만 표시
                Title = "Select a Text File" // 대화 상자 제목 설정
            };

            // 파일 브라우져가 열림
            string filePath = "";

            // 파일을 선택하면 해당 경로를 string filePath에 저장
            if (of.ShowDialog() == DialogResult.OK)
            {
                filePath = of.FileName; // 선택한 파일의 전체 경로를 가져옴
            }

            Console.WriteLine(filePath);
            CatTxtOnTextBox(filePath);
        }

        // async
        private async void CatTxtOnTextBox(string path)
        {
            // path에 있는 파일을 읽어서 textBox_content
            using (StreamReader sr = new StreamReader(path))
            {
                string content = await sr.ReadToEndAsync(); // 비동기적으로 파일 읽기
                textBox_content.Text = content; // 텍스트 박스에 내용 표시
            }
        }
    }
}
