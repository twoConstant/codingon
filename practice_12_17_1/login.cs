using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace practice_12_17_1
{
    public partial class login : Form
    {
        private readonly Dictionary<string, string> pwDicsById = new Dictionary<string, string>();
        private readonly Dictionary<string, string> phonDicsById = new Dictionary<string, string>();
        public login()
        {
            InitializeComponent();
        }

        private void button_filefinder_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        Console.WriteLine($"fileContent: {fileContent}");
                        FillDicsById(fileContent);
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }
        private void FillDicsById(string fileContent)
        {
            string[] lines = fileContent.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                Console.WriteLine($"line: {line}"); // 디버깅용
                string[] items = line.Split(',');

                if (items.Length < 3)
                {
                    // ID와 비밀번호만 있는 경우, 전화번호를 빈 문자열로 처리
                    string id = items[0];
                    string pw = items[1];
                    string phon = string.Empty;

                    pwDicsById[id] = pw;
                    phonDicsById[id] = phon;

                    Console.WriteLine($"id: {id}, pw: {pw}, phon: {phon}"); // 디버깅용
                    continue;
                }

                // ID, 비밀번호, 전화번호 모두 있는 경우
                string idWithPhone = items[0];
                string pwWithPhone = items[1];
                string phonWithPhone = items[2];

                pwDicsById[idWithPhone] = pwWithPhone;
                phonDicsById[idWithPhone] = phonWithPhone;

            }
        }
        

        private void button_login_Click(object sender, EventArgs e)
        {
            string id = textBox_ID.Text;
            string pw = textBox_PW.Text;

            if (Authenticated(id, pw))
            {
                MessageBox.Show($"로그인 성공, ID: {id}, Phon: {phonDicsById[id]}");
            }
            else
            {
                MessageBox.Show("로그인 실패");
            }

        }

        private bool Authenticated(string id, string pw)
        {
            if(!pwDicsById.ContainsKey(id))
            {
                return false;
            }

            return pwDicsById[id] == pw;
        }
    }

    
}
