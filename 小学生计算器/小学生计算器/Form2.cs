using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 小学生计算器
{
    public partial class Form2 : Form
    {
        public static int n = 0, sum = 0, m, temp;
        public int a, b, c;
        

        private void button1_Click(object sender, EventArgs e)
        {
           
            n = n + 1;
            label4.Text = n.ToString();
            if (n == 10) {
                button4.Enabled = true;
                button3.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("您的成绩:" + sum.ToString() + "分");


            }
            if (button1.Text == "开始")
            {

                button3.Text = "结束";
                label5.Text = "第";
                label6.Text = "题";
                button1.Text = "下一题";
                button3.Enabled = false;
                button4.Enabled = false;

                rand();
               
            }
            else
            {

                label3.Text = "";
                textBox3.Text = "";
                rand();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            MessageBox.Show("您的成绩:" + sum.ToString() + "分");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (button3.Text == "结束")
            {
                OnEndAction();
            }
            else if (button3.Text == "返回")
            {
                OnBackAction();
            }

        }
        private void OnEndAction()
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            Application.ExitThread();
            
        }

        private void OnBackAction()
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            Application.ExitThread();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

                        label3.Text = "做错了";
                        
                        
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

                        label3.Text = "做错了";
                       
                        
                    }; break;
            }

        }
    }
}
