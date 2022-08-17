using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace IT391_Unit6Assignment_SaraPak
{
    public partial class BackgrounndImage : Form
    {
        public BackgrounndImage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //validating a number within range
            int AgeRange;
            if (int.TryParse(AgeField.Text, out AgeRange))
{
                if (AgeRange >= 5 && AgeRange <= 18) 
                {
                    MessageBox.Show("That's the right age range!");
                }
                else
                {
                    MessageBox.Show("Age is out of Range!");
                }


            }
            //validating email 
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (Regex.IsMatch(EmailField.Text,pattern))
            {
                MessageBox.Show("Awesome!");
            }
            else
            {
                MessageBox.Show("Email requires an @ symbol");
            }

            
        }

        private void AgeField_Validating(object sender, CancelEventArgs e)
        {
            
            
        }
    }
}
