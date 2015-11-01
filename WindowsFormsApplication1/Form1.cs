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

        private static double currVal = 0;
        private static double tempVal = 0;
        private static int lastPressed = 0;

        public bool GoneThroughBefore = false;
        StringBuilder sb = new StringBuilder();
              
        public Form1()
        {
            InitializeComponent();
        }

#region [HELPER FUNCTIONS]
        //This function will take whatever number key is press and add it so the screen via 
        //stringbuilder, then it will take whatever is on the screen and assign it to the tempVal
        //so that if a calculation is done after this, the current number on screen can be processed
        private void buttonPressed(int x)
        {
            sb.Append(x);
            textBox1.Text = sb.ToString();
            tempVal = Convert.ToDouble(sb.ToString());
        }

        //This function takes the last operation button pressed along with the current numbers and computes them.
        //It is set up like this so that it calculates your last 2 numbers using the operation between them and not
        //the current operation being pressed. For example, if you pressed the following [4]->[+]->[10]->[-]..... when
        //you pressed the minus key, the computer would calculate 4+10 since it see the lastPressed as being a plus. When
        //the minus key is pressed in the forth keypress, the minus key is the new lastPressed.
        private static double calculateFromLast(double temp, double curr, int lastPressed)
        {
            //PERFORMS CALCULATION BASED ON OPERATION IN BETWEEN LAST 2 NUMBERS.
            //I could have technically done a switch statement but at the time I wasn't sure
            //if there would be other conditions besides just the last key pressed. Leaving
            //for now since I might later add other conditions.
            if (lastPressed == 1)
            {
                curr += temp;
            }
            else if (lastPressed == 2)
            {
                curr -= temp;
            }
            else if (lastPressed == 3)
            {
                curr = currVal * temp;
            }
            else if (lastPressed == 4)
            {
                if (tempVal != 0)
                {
                    curr = currVal / temp;
                }
                else
                {
                    curr = 0;
                }
            }
            else
            {
                curr = 0;
            }
            return curr;
        }
#endregion

#region [NUMBER BUTTONS]

        //1 BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            this.buttonPressed(1);
        }

        //2 BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            this.buttonPressed(2);
        }

        //3 BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            this.buttonPressed(3);
        }

        //4 BUTTON
        private void button4_Click(object sender, EventArgs e)
        {
            this.buttonPressed(4);
        }

        //5 BUTTON
        private void button5_Click(object sender, EventArgs e)
        {
            this.buttonPressed(5);
        }

        //6 BUTTON
        private void button6_Click(object sender, EventArgs e)
        {
            this.buttonPressed(6);
        }

        //7 BUTTON
        private void button7_Click(object sender, EventArgs e)
        {
            this.buttonPressed(7);
        }

        //8 BUTTON
        private void button8_Click(object sender, EventArgs e)
        {
            this.buttonPressed(8);
        }

        //9 BUTTON
        private void button9_Click(object sender, EventArgs e)
        {
            this.buttonPressed(9);
        }

        //0 BUTTON
        private void button11_Click(object sender, EventArgs e)
        {
            this.buttonPressed(0);
        }

        //RANDOM NUMBER BUTTON - generates a number between 1 and 5000
        //and treats it as if it was a number that the user entered
        private void button17_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            this.buttonPressed(Convert.ToInt32(randNum.Next(1, 5000)));
        }
#endregion

#region [OPERATION BUTTONS]
        //PLUS BUTTON
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
            currVal = calculateFromLast(currVal, tempVal, lastPressed);
            
            textBox1.Text = currVal.ToString();
            lastPressed = 1;
            sb.Clear();
        }

        //MINUS BUTTON
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
            currVal = calculateFromLast(currVal, tempVal, lastPressed);

            textBox1.Text = currVal.ToString();
            lastPressed = 2;
            sb.Clear();
        }

        //MULTIPLY BUTTON
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
            currVal = calculateFromLast(currVal, tempVal, lastPressed);

            textBox1.Text = currVal.ToString();
            lastPressed = 4;
            sb.Clear();
        }

        //DIVIDE BUTTON
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
            currVal = calculateFromLast(currVal, tempVal, lastPressed);

            textBox1.Text = currVal.ToString();
            lastPressed = 3;
            sb.Clear();
        }
        //EQUALS BUTTON - Calculates based on last 3 buttons pressed (2 numbers and operation in between them)
        private void button10_Click_1(object sender, EventArgs e)
        {
            currVal = calculateFromLast(currVal, tempVal, lastPressed);

            textBox1.Text = currVal.ToString();
            sb.Clear();
            lastPressed = 0;
        }

#endregion

#region [MISC BUTTONS]
        //CLEAR BUTTON - resets the text box, clears string builder and resets
        //the values.
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            currVal = 0;
            tempVal = 0;
            lastPressed = 0;
            sb.Clear();
        }
#endregion
        
    }
    
}
