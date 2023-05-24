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


        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;

        public Form4()
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
            dataGridView2.DataSource = dt;
            con.Close();
        }
        // Clears the Data  
        private void ClearData()
        {
            employeetxt.Text = "";
            nametxt.Text = "";
            surnametxt.Text = "";
            emailtxt.Text = "";
            salarytxt.Text = "";
            deparmenttxt.Text = "";
            addresstxt.Text = "";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

         private void employeetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (nametxt.Text != "" && surnametxt.Text != "" && employeetxt.Text != "")
            {
                cmd = new MySqlCommand("delete from hrmsproject.employees where id=@idd", con);
                con.Open();
                cmd.Parameters.AddWithValue("@idd", employeetxt.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Successfully Deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Select the record you want to Delete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

  

        private void Addbtn_Click(object sender, EventArgs e)
        {
            // Checks if Username Exists
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM hrmsproject.employees WHERE name = @nme", con);
            cmd1.Parameters.AddWithValue("@nme", nametxt.Text);
            con.Open();
            bool userExists = false;
            using (var dr1 = cmd1.ExecuteReader())
                if (userExists = dr1.HasRows)
                    MessageBox.Show("Username not available!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
            if (!(userExists))
            {
                // Adds a User in the Database
                if (nametxt.Text != "" && surnametxt.Text != "")
                {
                    cmd = new MySqlCommand("insert into hrmsproject.employees(id,name,surname, salary, address, department, emailaddress) values(NULL,@nme,@sne,@sal,@adr,@dpt,@email)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@nme", nametxt.Text);
                    cmd.Parameters.AddWithValue("@sne", surnametxt.Text);
                    cmd.Parameters.AddWithValue("@sal", salarytxt.Text);
                    cmd.Parameters.AddWithValue("@adr", addresstxt.Text);
                    cmd.Parameters.AddWithValue("@dpt", deparmenttxt.Text);
                    cmd.Parameters.AddWithValue("@email", emailtxt.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Successfully Added", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Fill out all the information needed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        

        }

        private void showdata_Click(object sender, EventArgs e)
        {
            DisplayData();
            ClearData();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (nametxt.Text != "" && surnametxt.Text != "" && employeetxt.Text != "" && salarytxt.Text != "" && addresstxt.Text != "" && deparmenttxt.Text != "" && emailtxt.Text != "")
            {
                cmd = new MySqlCommand("update hrmsproject.employees set name=@nme, surname=@sne, salary=@sal, address=@adr, department=@dpt, emailaddress=@email where id=@idd", con);
                con.Open();
                cmd.Parameters.AddWithValue("@idd", employeetxt.Text);
                cmd.Parameters.AddWithValue("@nme", nametxt.Text);
                cmd.Parameters.AddWithValue("@sne", surnametxt.Text);
                cmd.Parameters.AddWithValue("@sal", salarytxt.Text);
                cmd.Parameters.AddWithValue("@adr", addresstxt.Text);
                cmd.Parameters.AddWithValue("@dpt", deparmenttxt.Text);
                cmd.Parameters.AddWithValue("@email", emailtxt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Successfully Updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Select the record you want to Update", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            employeetxt.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            nametxt.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            surnametxt.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            salarytxt.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            addresstxt.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            deparmenttxt.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            emailtxt.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
