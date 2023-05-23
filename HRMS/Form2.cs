using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Logoutbutton1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void employeesbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }

        private void departmentsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }
    }
}
