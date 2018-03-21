using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 10;
            int lenth = Convert.ToInt16(textBox1.Text);    //寄存器的位数
            int no = lenth;
            int a = Convert.ToInt16(textBox2.Text, 2);  //将输入的字符窜转化为二进制数
            int b = Convert.ToInt16(textBox3.Text, 2);
            int a1 = Convert.ToInt16(textBox4.Text);         //读取要反馈的位数
            int a2 = Convert.ToInt16(textBox5.Text);
            int b1 = Convert.ToInt16(textBox6.Text);
            int b2 = Convert.ToInt16(textBox7.Text);
            if (textBox9.Text != "")
                n = Convert.ToInt16(textBox9.Text);          //读取要输出的位数
            if(textBox8.Text!="")
                no = Convert.ToInt16(textBox8.Text);        //从第no级输出
            textBox9.Text = n.ToString();
            textBox8.Text = no.ToString();
            int no1 = lenth - no;
            string str=null;                              //作为输出结果的字符串
            int c;                                 //作为接受每次输出的数字
            int x, y;                            //用于反馈的值
            int a3, b3;                          //用于


             for(int i=0;i<n;i++)                 //n次循环输出n次的结果
            {
                c = (a ^ b) >>no1 &1;            //取出第i次第no为模二加的值
                str += c.ToString();             //加到输出的字符上
                textBox10.Text = str;

                a3 = a;x = a >>(lenth- a1) & 1;          //去出第i次的a1,a2位的反馈
                a3 = a;y = a >> (lenth-a2) & 1;
                x = x ^ y;
                a= (a >> 1);
                x=x << lenth-1;
                a = a | x;

                b3 = b; x = b >>(lenth- b1) & 1;          //去出第i次的b1,b2位的反馈
                b3 = b; y = b >>(lenth- b2 )& 1;
                x = x ^ y;
                b = (b >> 1);
                x = x << lenth-1;
                b = b | x;

            }
        }
    }
}
