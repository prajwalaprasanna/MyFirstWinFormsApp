using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsApp
{
    public partial class ContactInfo : Form
    {
        public ContactInfo()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ContactInfo_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string conString = ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conString))
            { 
                string query = @"INSERT INTO Employee
                    (FirstName, LastName, FullName, BirthDate, Title, Prefix, 
                     Address, City, State, ZIPCode, HomePhone, MobilePhone, Email, Skype,DeptId)
                    VALUES
                    (@FirstName, @LastName, @FullName, @BirthDate, @Title, @Prefix, 
                     @Address, @City, @State, @ZIPCode, @HomePhone, @MobilePhone, @Email, @Skype,@DeptId)";
           
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                 
                    cmd.Parameters.AddWithValue("@FirstName", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@FullName", textBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@BirthDate", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@Title",textBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@Prefix",comboBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", textBox5.Text.Trim());
                    cmd.Parameters.AddWithValue("@City", textBox6.Text.Trim());
                    cmd.Parameters.AddWithValue("@State", comboBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@ZIPCode", textBox7.Text.Trim());
                    cmd.Parameters.AddWithValue("@HomePhone", textBox8.Text.Trim());
                    cmd.Parameters.AddWithValue("@MobilePhone", textBox9.Text.Trim()); // required
                    cmd.Parameters.AddWithValue("@Email", textBox10.Text.Trim());        // required + unique
                    cmd.Parameters.AddWithValue("@Skype", textBox11.Text.Trim());
                    

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee inserted successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
