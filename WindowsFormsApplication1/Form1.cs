using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //public string display { get; set; }

        public static double currVal = 0;
        public static double tempVal = 0;
        public static int lastPressed;

        public bool GoneThroughBefore = false;
        StringBuilder sb = new StringBuilder();
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPressed(int x)
        {
            sb.Append(x);
            textBox1.Text = sb.ToString();
            tempVal = Convert.ToDouble(sb.ToString());
        }
        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            currVal = 0;
            tempVal = 0;
            sb.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            this.buttonPressed(Convert.ToInt32(randNum.Next(1,5000)));

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            switch(lastPressed)
            {
                case 1:
                    currVal += tempVal;
                    break;
                case 2:
                    currVal -= tempVal;
                    break;
                case 3:
                    currVal = currVal * tempVal;
                    break;
                case 4:
                    if(tempVal != 0)
                    {
                        currVal = currVal / tempVal;
                    }
                    else
                    {
                        currVal = 0;
                    }
                    break;
                default:
                    currVal = 0;
                    break;
            }
            textBox1.Text = currVal.ToString();
            sb.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.buttonPressed(1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.buttonPressed(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.buttonPressed(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.buttonPressed(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.buttonPressed(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.buttonPressed(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.buttonPressed(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.buttonPressed(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.buttonPressed(9);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.buttonPressed(0);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                tempVal = Convert.ToDouble(sb.ToString());
            }
            catch
            {
                tempVal = 0;
            }
            currVal += tempVal;
            textBox1.Text = currVal.ToString();
            lastPressed = 1;
            sb.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                tempVal = Convert.ToDouble(sb.ToString());
            }
            catch
            {
                tempVal = 0;
            }    
            currVal -= tempVal;
            textBox1.Text = currVal.ToString();
            lastPressed = 2;
            sb.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                tempVal = Convert.ToDouble(sb.ToString());
            }
            catch
            {
                tempVal = 544;
            }
            currVal = currVal * tempVal;
            textBox1.Text = currVal.ToString();
            lastPressed = 4;
            sb.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                tempVal = Convert.ToDouble(sb.ToString());
            }
            catch
            {
                tempVal = 0;
            }
            currVal = currVal / tempVal;
            textBox1.Text = currVal.ToString();
            lastPressed = 3;
            sb.Clear();
        }
    }
}
