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
    public partial class GrammarCheck : Form
    {
        public GrammarCheck()
        {
            InitializeComponent();
            LoadSuggestions();
        }

        private void GrammarCheck_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {


            ActiveForm.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadSuggestions()
        {
            List<string> suggestions = new List<string>()
            {
                "uncomplicated"

            };
            listBox2.DataSource = suggestions;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
