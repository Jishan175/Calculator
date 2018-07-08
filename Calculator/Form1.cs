using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double value = 0;
        string opt="";
        bool isPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if((textBox1.Text =="0")||(isPressed))
            
                textBox1.Clear();
                isPressed = false;
                Button b = (Button)sender;
                textBox1.Text += b.Text;
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            opt = b.Text;
            value = Double.Parse(textBox1.Text);
            isPressed = true;
            label1.Text = value + "" + opt;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text += textBox1.Text;
            switch (opt)
            {
                case "+":
                    textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;


            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text="";
            value = 0;
            textBox1.Text =0.ToString();
        }
    }
}
