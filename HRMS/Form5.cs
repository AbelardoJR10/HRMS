using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRMS
{
    public partial class Form5 : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hrmsproject");

        string connectionString = @"Data Source=localhost;username=root; Initial Catalog= hrmsproject; Integrated Security = True";


        public Form5()
        {
            InitializeComponent();
        }

        private void showdatabtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            {
                sqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT * FROM `employees` ", sqlCon);
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);

                //method
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dtb1;

            }
        }

        private void homebtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void viewtextboxbtn_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
