using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_12_17_1
{
    public partial class Form7 : Form
    {

        public Form7()
        {
            InitializeComponent();
            
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            // 유효성 판단.
            if(!(int.TryParse(textBox1.Text, out int size) && size > 0))
            {
                return;
            }

            // Student만들면서 추가하기
            for(int i = 0; i < size; i++)
            {
                Student student = new Student((i + 1) + "", StudentManager<Student>.getRandomScore());
                studentManager.add(student);
            }

            // 출력하기
            textBox2.Text = studentManager.ToString();
        }

        private class StudentManager<T> where T : Student
        {
            // 멤버 변수
            private readonly List<T> list;
            private readonly StringBuilder sb = new StringBuilder();
            private static readonly Random random = new Random();

            // 생성자
            public StudentManager(List<T> list)
            {
                this.list = list;
            }

            // 메서드
            // add
            public void add(T student)
            {
                list.Add(student);
            }

            public static int getRandomScore()
            {
                return random.Next(0, 101);
            }

            private void clear()
            {
                list.Clear();
            }

            // toString
            public override string ToString()
            {
                // StringBuilder 초기화
                sb.Clear();

                // while 루프를 사용하여 리스트 순회
                int index = 0;
                while (index < list.Count)
                {
                    T student = list[index];
                    sb.AppendLine($"학생: {student.getName()}, 성적: {student.getScore()}");
                    index++;
                }

                // 완성된 문자열 반환
                clear();
                return sb.ToString();
            }

        }

        private class Student
        {
            private string name;
            private int score;

            public Student(string name, int score)
            {
                this.name = name;
                this.score = score;
            }

            // 메서드
            public string getName()
            {
                return name;
            }

            public int getScore()
            {
                return score;
            }
        }

    }
}
