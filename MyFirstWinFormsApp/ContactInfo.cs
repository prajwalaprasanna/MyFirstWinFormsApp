using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsApp
{
    public partial class ContactInfo : Form
    {
        string conString = ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString;

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

        private async void ContactInfo_Load(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "Select DeptId,DepartmentName from Department";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();

                try
                {
                    con.Open();
                    adapter.Fill(dataTable);
                    DataRow dr = dataTable.NewRow();
                    dr["DeptId"] = DBNull.Value; // Use NULL for the ID or a specific indicator like -1 or 0
                    dr["DepartmentName"] = "-- Select --";
                    dataTable.Rows.InsertAt(dr, 0);
                    comboBox2.DataSource = dataTable;
                    comboBox2.DisplayMember = "DepartmentName";
                    comboBox2.ValueMember = "DeptId";

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error loading departments: " + ex.Message);
                }
                await LoadEmployeeDataAsync();
            }
            dataGridView1.AllowUserToAddRows = false;


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // string deptName = comboBox2.Text;
            // int departmentId = GetDeptId(deptName);
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
                    cmd.Parameters.AddWithValue("@Title", textBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@Prefix", comboBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", textBox5.Text.Trim());
                    cmd.Parameters.AddWithValue("@City", textBox6.Text.Trim());
                    cmd.Parameters.AddWithValue("@State", comboBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@ZIPCode", textBox7.Text.Trim());
                    cmd.Parameters.AddWithValue("@HomePhone", textBox8.Text.Trim());
                    cmd.Parameters.AddWithValue("@MobilePhone", textBox9.Text.Trim()); // required
                    cmd.Parameters.AddWithValue("@Email", textBox10.Text.Trim());        // required + unique
                    cmd.Parameters.AddWithValue("@Skype", textBox11.Text.Trim());
                    cmd.Parameters.AddWithValue("@DeptId", comboBox2.SelectedValue);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee inserted successfully!");
                        ContactInfo_Load(sender, e);
                        await LoadEmployeeDataAsync();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView3.AllowUserToAddRows = false;
        }
        private int GetDeptId(string name)
        {
            int departmentId = 0;
            string queryString = "SELECT DepartmentID FROM Department WHERE DepartmentName = @DepartmentName";
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(queryString, con))
                {
                    command.Parameters.AddWithValue("@DepartmentName", name);

                    try
                    {
                        var result = command.ExecuteScalar();

                        if (result != null)
                        {
                            departmentId = Convert.ToInt32(result.ToString());

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error retrieving department name: " + ex.Message);
                        // You might want to log the exception or throw it further up
                    }
                }
            }
            return departmentId;
        }
        /*   private void LoadEmployeeData()
           {

               using (SqlConnection con = new SqlConnection(conString))
               {
                   string query = "SELECT EmployeeId,FirstName,BirthDate FROM Employee";
                   using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                   {
                       DataTable dataTable = new DataTable();
                       try
                       {
                           con.Open();
                           adapter.Fill(dataTable);
                           dataGridView3.DataSource = dataTable;
                       }
                       catch (SqlException ex)
                       {
                           MessageBox.Show("An error occurred: " + ex.Message);
                       }
                   }
               }

           }*/
        private async Task LoadEmployeeDataAsync(CancellationToken ct = default)
        {
            var dataTable = new DataTable();

            using (var con = new SqlConnection(conString))
            using (var cmd = new SqlCommand(
                "SELECT EmployeeId, FirstName, BirthDate FROM Employee", con))
            {
                await con.OpenAsync(ct);

                // Execute the query asynchronously
                using (var reader = await cmd.ExecuteReaderAsync(ct))
                {
                    // DataTable.Load is synchronous, but the I/O to fetch rows is already async above
                    dataTable.Load(reader);
                }
            }

            // This runs back on the UI thread (because we're in WinForms and didn't use ConfigureAwait(false))
            dataGridView3.DataSource = dataTable;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}