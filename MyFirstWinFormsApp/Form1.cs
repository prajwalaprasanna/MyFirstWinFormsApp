using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace MyFirstWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            Regex nameRegex = new Regex("^[A-Za-z]+$");
            bool isValid = nameRegex.IsMatch(textBox1.Text);
            if (!isValid)
            {
                MessageBox.Show("Only letters allowed");
            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Regex nameRegex = new Regex("^[A-Za-z]+$");
            bool isValid = nameRegex.IsMatch(textBox1.Text);
            if (!isValid)
            {
                MessageBox.Show("Only letters allowed");
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            try
            {
                var addr = new MailAddress(email);
                // Ensures the input equals the normalized address
                return addr.Address == email.Trim();
            }
            catch
            {
                return false;
            }
        }
            private void button1_Click(object sender, EventArgs e)
        {

            var email = EmailId.Text?.Trim() ?? string.Empty;

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmailId.Focus();
                return;
            }

            MessageBox.Show("Data saved successfully");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
