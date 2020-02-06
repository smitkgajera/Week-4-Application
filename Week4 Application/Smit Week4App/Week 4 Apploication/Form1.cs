using System;
using System.Windows.Forms;

namespace Week_4_Apploication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
       
        /// This method is to initialize the Form1 component
       
       private void Form1_Load(object sender, EventArgs e)
        {
            
            Random rand = new Random();
             int num1 = rand.Next(1, 10);
             int num2 = rand.Next(1, 10);
            textBox1.Text = num1.ToString();
            textBox2.Text = num2.ToString();
            Output.Text = " ";
        }
    private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                label2.Text = "+";
            }
            catch (Exception)
            {
                MessageBox.Show("This is wrong");
            }
        }

      
       /// The above method is for addition opertion to display add symbol.
       
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try 
            { 
            label2.Text = "-";
            }
            catch (Exception)
            {
                MessageBox.Show("This is wrong");
            }
        }
        /// <summary>
        /// The above method is for subtraction operation to display subtract symbol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random rand = new Random();
                int num1 = rand.Next(1, 10);
                int num2 = rand.Next(1, 10);

                textBox1.Text = num1.ToString();
                textBox2.Text = num2.ToString();
                textBox3.Clear();
                Output.Text= " ";
            }
            catch (Exception)
            {
                MessageBox.Show("This is wrong");
            }
        }
       
        /// The above method is for the next button to generate the random numbers when clicked on next button
       
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {   try
            {
             label2.Text = "*";
            }
            catch (Exception)
            {
                MessageBox.Show("This is wrong");
            }
        }
       
        /// This method is  for the Multiplication operation when clicked on multiplication to display multiply sign
       

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {   try
            {
            label2.Text = "/";
            }
            catch (Exception)
            {
                MessageBox.Show("This is wrong");
            }
        }
       
        /// The above method is for the division operation to display the division symbol
       
        private void button2_Click(object sender, EventArgs e)
        {
            if (Add.Checked == true)
            {   try
                {
                    int number1 = int.Parse(textBox1.Text);
                    int number2 = int.Parse(textBox2.Text);
                    int number3 = int.Parse(textBox3.Text);
                    int Result = number1 + number2;
                    if (number3 == Result)
                    {
                        Output.Text = "Right";
                    }
                    else
                    {
                        Output.Text = "Wrong. Answer is" + Result;
                    }
                }
                catch (Exception )
                {
                    MessageBox.Show("This is wrong");
                }
            }

            /// The above function is to perform the addition operation when clicked on Am i right button 
            if (Subtract.Checked == true)
            {   try
                {
                    int number1 = int.Parse(textBox1.Text);
                    int number2 = int.Parse(textBox2.Text);
                    int number3 = int.Parse(textBox3.Text);
                    int Result = number1 - number2;
                    if (number3 == Result)
                    {
                        Output.Text = "Right";
                    }
                    else
                    {
                        Output.Text = "Wrong. Answer is" + Result;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("This is wrong");
                }
            }
            /// The above function is to perform subtraction operation when clicked on the Am i right button
            if (Multiply.Checked == true)
            {   try
                {
                    int number1 = int.Parse(textBox1.Text);
                    int number2 = int.Parse(textBox2.Text);
                    int number3 = int.Parse(textBox3.Text);
                    int Result = number1 * number2;
                    if (number3 == Result)
                    {
                        Output.Text = "Right";
                    }
                    else { Output.Text = "Wrong. Answer is" + Result; }
                }
                catch (Exception)
                {
                    MessageBox.Show("This is wrong");
                }
            }
            /// The above function is to perform Multiplication operation when clicked on Am i right button 

            if (Divide.Checked == true)
            {   
                try
                { 

                double number1 = double.Parse(textBox1.Text);
                double number2 = double.Parse(textBox2.Text);
                double number3 = double.Parse(textBox3.Text);
                double Result = number1 / number2;
                if (number3 == Result)
                {
                    Output.Text = "Right";
                }
                else { Output.Text = "Wrong. Answer is" + Result; }
                }
                catch (Exception)
                {
                    MessageBox.Show("This is wrong");
                }
            }
            /// The above function is to perform division operation when clicked on Am i right button 
        }
        
        ///  The above functions are written for Am i right button to perform math operations.
       

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("This is wrong");
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.TextAlign = HorizontalAlignment.Center;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Output_Click(object sender, EventArgs e)
        {

        }

        private void Solution_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        /// The above method is for I'm done button to close the application once done

    }
}
