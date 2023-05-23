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
    public partial class Form4 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hrmsproject");

        string connectionString = @"Data Source=localhost;username=root; Initial Catalog= hrmsproject; Integrated Security = True";


        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

         private void employeetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

  

        private void Addbtn_Click(object sender, EventArgs e)
        {

            //add an employee

            DB db = new DB();

            MySqlCommand command = new MySqlCommand(" INSERT INTO `employees`(`name`, `surname`, `salary`, `address`, `department`, `emailaddress`) VALUES (@nme,@sne,@sal,@adr,@dpt,@email) ", db.getConnection());

            command.Parameters.Add("@nme", MySqlDbType.VarChar).Value = nametxt.Text;
            command.Parameters.Add("@sne", MySqlDbType.VarChar).Value = surnametxt.Text;
            command.Parameters.Add("@sal", MySqlDbType.Int64).Value = salarytxt.Text;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = addresstxt.Text;
            command.Parameters.Add("@dpt", MySqlDbType.VarChar).Value = deparmenttxt.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailtxt.Text;

            //open connection 
            db.openConnection();

            //execute the query  
            if (command.ExecuteNonQuery () == 1)
            {
                MessageBox.Show("Employee Added");
            }
            else
            {
                MessageBox.Show("Error");
            }

            //close connection
            db.closeConnection();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void showdata_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            {
                sqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT * FROM `employees` ", sqlCon);  
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);

                //method
                dataGridView2.AutoGenerateColumns = true;
                dataGridView2.DataSource = dtb1;
             
            }    
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
           
        }

        //check if employee already exists 



    }
}
