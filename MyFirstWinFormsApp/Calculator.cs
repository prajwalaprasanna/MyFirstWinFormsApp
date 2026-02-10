using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsApp
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            int res = Convert.ToInt32(FirstNumber.Text) + Convert.ToInt32(SecondNumber.Text);
            Summation.Text = Convert.ToString(res);
            MessageBox.Show("Summation is successful");
            DialogResult result = MessageBox.Show("Summation is done.Do you want to add more numbers","Confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FirstNumber.Text = "";
                SecondNumber.Text = "";
                Summation.Text = "";
                FirstNumber.Focus();
            }
            else
            {

            }
        }
    }
}
