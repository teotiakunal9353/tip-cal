using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tip_calculator
{
   
    public partial class Form1 : Form
    {
        //declaring the variable
        Double Tip, Bill, Person, Total, Tipp, Personn, Finaltotal;


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Bill = Convert.ToDouble(textBox1.Text);  //taking the input of bill
                Tip = Convert.ToDouble(numericUpDown1.Text); //taking the input of tip%
                Person = Convert.ToDouble(numericUpDown2.Text);//taking the input of number of persons



                Tipp = Bill * Tip / 100; //calculating the tip from bill
                Personn = Tipp / Person; //calulating the tip per person
                Finaltotal = Bill + Tipp; //calculating the total amont
                Total = Finaltotal / Person; //calculating the amount per person

                textBox2.Text = Personn.ToString();
                textBox3.Text = Total.ToString();
                textBox4.Text = Finaltotal.ToString();
                textBox5.Text = Tipp.ToString();
            }
            catch
            {
                MessageBox.Show("invalid input");//printing the invalid out put

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
