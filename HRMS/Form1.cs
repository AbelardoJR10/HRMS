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
    public partial class Form1 : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hrmsproject");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String username = TxtUsername.Text;
            String password = TxtPassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn and `password` = @pass", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            //check if the user exists or not 

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("YES, SUCCESSFUL LOGIN");
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.ShowDialog();

            }
            else
            {
                MessageBox.Show("NO");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
