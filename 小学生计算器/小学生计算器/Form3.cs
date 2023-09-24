using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 小学生计算器
{
    public partial class Form3 : Form
    {
        public static int n = 0, sum = 0, m, temp;
        public int a, b, c;

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            Application.ExitThread();
        }

        public void rand()
        {
            Random ra = new Random();
            a = ra.Next(0, 10);
            b = ra.Next(0, 10);
            m = ra.Next(0, 2);
            switch (m)
            {
                case 0: label1.Text = "+"; break;
                case 1:
                    if (a < b)
                    {
                        temp = a;
                        a = b;
                        b = temp;
                    }
                    label1.Text = "-"; break;
            }
            textBox1.Text = a.ToString();
            textBox2.Text = b.ToString();
            textBox3.Focus();
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (button1.Text == "开始")
            {
                button1.Text = "下一题";
                rand();
            }
            else
            {

                label3.Text = " ";
                textBox3.Text = "";
                rand();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "";
                return;
            }

            
             int c = Convert.ToInt32(textBox3.Text);

            switch (m)
            {
                case 0:
                    if (a + b == c)
                    {
                        label3.Text = "做对了，你真棒！";
                        button1.Focus();
                        sum = sum + 10;
                    }
                    else
                    {

                        label3.Text = "做错了，再想想！";
                        textBox3.SelectAll();
                        textBox3.Focus();
                    }; break;
                case 1:
                    if (a - b == c)
                    {
                        label3.Text = "做对了，你真棒！";
                        button1.Focus();
                        sum = sum + 10;
                    }
                    else
                    {

                        label3.Text = "做错了，再想想！";
                        textBox3.SelectAll();
                        textBox3.Focus();
                    }; break;
            }
        }
    }
    }

