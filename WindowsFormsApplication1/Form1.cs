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
        private static double currVal = 0;
        private static double tempVal = 0;
        private static double historyValue = 0;
        private static int lastPressed = 0;
        private static bool firstTime = true;
        StringBuilder sb = new StringBuilder();
                   
        public Form1()
        {
            InitializeComponent();
        }

#region HELPER FUNCTIONS
        //This function will take whatever number key is press and add it so the screen via 
        //stringbuilder, then it will take whatever is on the screen and assign it to the tempVal
        //so that if a calculation is done after this, the current number on screen can be processed
        private void buttonPressed(int x)
        {
            sb.Append(x);
            ScreenDisplay.Text = sb.ToString();
            tempVal = Convert.ToDouble(sb.ToString());
        }

        //sets a tempVal thats used for various purposes, based on whether or not this is an ongoing calculation or a new calculation.
        private void tempValLogic()
        {
            try
            {
                tempVal = Convert.ToDouble(sb.ToString());
            }
            catch
            {
                if (firstTime)
                    tempVal = 0;
                if (!firstTime)
                    tempVal = historyValue;
            }
        }

        //This function performs all the logic that takes place when the =,-,*,/ button gets hit
        private void operatorButtonLogic(int lastPressParam)
        {
            tempValLogic();
            firstTime = false;
            currVal = calculateFromLast(currVal, tempVal, lastPressed);
            currVal = Math.Round(currVal, 5);
            historyValue = currVal;
            ScreenDisplay.Text = currVal.ToString();
            lastPressed = lastPressParam;
            sb.Clear();
        }

        //This function takes the last operation button pressed along with the current numbers and computes them.
        //It is set up like this so that it calculates your last 2 numbers using the operation between them and not
        //the current operation being pressed. For example, if you pressed the following [4]->[+]->[10]->[-]..... when
        //you pressed the minus key, the computer would calculate 4+10 since it see the lastPressed as being a plus. When
        //the minus key is pressed in the forth keypress, the minus key is the new lastPressed.
        private static double calculateFromLast(double temp, double curr, int lastPressed)
        {
            //PERFORMS CALCULATION BASED ON OPERATION IN BETWEEN LAST 2 NUMBERS.
            switch (lastPressed)
                {
                    case 1:
                        curr = temp + curr;
                        break;
                    case 2:
                        curr = temp - curr;
                        break;
                    case 3:
                        try
                        {
                        curr = temp / curr; ;
                        }
                        catch (DivideByZeroException ex)
                        {
                            MessageBox.Show("Unable to divide by zero, please try again");
                        }
                        break;
                    case 4:
                        curr = temp * curr;
                        break;

                    case 0:
                        break;
                    default:
                        break;
                }

            return curr;
        }
#endregion

#region NUMBER BUTTONS

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

#region OPERATION BUTTONS

        //PLUS BUTTON
        private void button14_Click(object sender, EventArgs e)
        {
            operatorButtonLogic(1);
        }
        //MINUS BUTTON
        private void button12_Click(object sender, EventArgs e)
        {
            operatorButtonLogic(2);
        }
        //DIVIDE BUTTON
        private void button13_Click(object sender, EventArgs e)
        {
            operatorButtonLogic(3);
        }
        //MULTIPLY BUTTON
        private void button15_Click(object sender, EventArgs e)
        {
            operatorButtonLogic(4);
        }
        //EQUALS BUTTON - Calculates based on last 3 buttons pressed (2 numbers and operation in between them)
        private void button10_Click_1(object sender, EventArgs e)
        {
            currVal = calculateFromLast(currVal, tempVal, lastPressed);
            currVal = Math.Round(currVal, 5);
            firstTime = false;
            ScreenDisplay.Text = currVal.ToString();
            historyValue = currVal;
            sb.Clear();
            lastPressed = 0;
        }

#endregion

        //CLEAR BUTTON - resets the text box, clears string builder and resets
        //the values.
        private void button16_Click(object sender, EventArgs e)
        {
            ScreenDisplay.Text = "0";
            firstTime = true;
            currVal = 0;
            tempVal = 0;
            lastPressed = 0;
            sb.Clear();
        }

    }
    
}
