using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace basic_sentence
{
    public partial class Form1 : Form
    {
        byte myAge = 29;
        short pageNum = 10000;
        int myBalance = 2000000000;
        float gravity = 9.8f;
        double piValue = 3.14159265842;
        decimal numOfStar = 12231323134235324313543234540.00000m;

        public Form1()
        {
            InitializeComponent();
            textBox_print.AppendText(myAge.GetType() + " myAge: " + myAge + Environment.NewLine);
            textBox_print.AppendText(pageNum.GetType() + " pageNum: " + pageNum + Environment.NewLine);
            textBox_print.AppendText(myBalance.GetType() + " myBalance: " + myBalance + Environment.NewLine);
            textBox_print.AppendText(gravity.GetType() + " gravity: " + gravity + Environment.NewLine);
            textBox_print.AppendText(piValue.GetType() + " piValue: " + piValue + Environment.NewLine);
            textBox_print.AppendText(numOfStar.GetType() + " numOfStar: " + numOfStar + Environment.NewLine);

        }
    }
}
