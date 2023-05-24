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

        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlDataAdapter adapt;
        DataTable dt; 
 

        public Form5()
        {
            InitializeComponent();
            DisplayData();
        }

        // Displays the data in Data Grid View  
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from hrmsproject.employees", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        // Clears the Data  
        private void ClearData()
        {
            //txtIDSearch.Text = "";
            viewtextboxbtn.Text = "";
        }


        private void showdatabtn_Click(object sender, EventArgs e)
        {
            DisplayData();
            ClearData();
        }
   
      
        private void homebtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            // Checks if Username Exists
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM hrmsproject.employees WHERE name = @nme", con);
            cmd1.Parameters.AddWithValue("@nme", viewtextboxbtn.Text);
            con.Open();
            bool userExists = false;
            using (var dr1 = cmd1.ExecuteReader())
                if (userExists = dr1.HasRows)
                    adapt = new MySqlDataAdapter("select * from hrmsproject.employees where name like '" + viewtextboxbtn.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            ClearData();
            con.Close();

            if (!(userExists))
            {
                MessageBox.Show("Username not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
                ClearData();
            }


        }

        private void viewtextboxbtn_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

