namespace HRMS
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.homebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.surnametxt = new System.Windows.Forms.TextBox();
            this.salarytxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.deparmenttxt = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.employeetxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.showdata = new System.Windows.Forms.Button();
            this.idGridView1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGridView2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameGridView3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryGridView4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGridView5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentGridView6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailGridView7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.homebtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1510, 105);
            this.panel1.TabIndex = 0;
            // 
            // homebtn
            // 
            this.homebtn.Location = new System.Drawing.Point(1324, 36);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(147, 50);
            this.homebtn.TabIndex = 2;
            this.homebtn.Text = "Home ";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(148, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add employee";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::HRMS.Properties.Resources._656_6560404_icons8_staff_filled_1400_icon_hd_png_download;
            this.pictureBox1.InitialImage = global::HRMS.Properties.Resources._656_6560404_icons8_staff_filled_1400_icon_hd_png_download;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Surname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "address";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 30);
            this.label8.TabIndex = 1;
            this.label8.Text = "Deparment ";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(177, 249);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(208, 36);
            this.nametxt.TabIndex = 2;
            // 
            // surnametxt
            // 
            this.surnametxt.Location = new System.Drawing.Point(177, 311);
            this.surnametxt.Name = "surnametxt";
            this.surnametxt.Size = new System.Drawing.Size(208, 36);
            this.surnametxt.TabIndex = 2;
            // 
            // salarytxt
            // 
            this.salarytxt.Location = new System.Drawing.Point(598, 177);
            this.salarytxt.Name = "salarytxt";
            this.salarytxt.Size = new System.Drawing.Size(208, 36);
            this.salarytxt.TabIndex = 2;
            this.salarytxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(598, 246);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(208, 36);
            this.addresstxt.TabIndex = 2;
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.Red;
            this.Addbtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Addbtn.Location = new System.Drawing.Point(909, 176);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(90, 36);
            this.Addbtn.TabIndex = 3;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Red;
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.deletebtn.Location = new System.Drawing.Point(909, 308);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(90, 36);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.BackColor = System.Drawing.Color.Red;
            this.Editbtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Editbtn.Location = new System.Drawing.Point(909, 246);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(90, 36);
            this.Editbtn.TabIndex = 3;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = false;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // deparmenttxt
            // 
            this.deparmenttxt.Location = new System.Drawing.Point(598, 306);
            this.deparmenttxt.Name = "deparmenttxt";
            this.deparmenttxt.Size = new System.Drawing.Size(208, 36);
            this.deparmenttxt.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGridView1,
            this.nameGridView2,
            this.surnameGridView3,
            this.salaryGridView4,
            this.addressGridView5,
            this.departmentGridView6,
            this.EmailGridView7});
            this.dataGridView2.Location = new System.Drawing.Point(34, 468);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1156, 208);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // employeetxt
            // 
            this.employeetxt.Location = new System.Drawing.Point(177, 186);
            this.employeetxt.Name = "employeetxt";
            this.employeetxt.Size = new System.Drawing.Size(208, 36);
            this.employeetxt.TabIndex = 7;
            this.employeetxt.TextChanged += new System.EventHandler(this.employeetxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(177, 377);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(208, 36);
            this.emailtxt.TabIndex = 9;
            // 
            // showdata
            // 
            this.showdata.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showdata.Location = new System.Drawing.Point(1016, 393);
            this.showdata.Name = "showdata";
            this.showdata.Size = new System.Drawing.Size(174, 54);
            this.showdata.TabIndex = 10;
            this.showdata.Text = "show data";
            this.showdata.UseVisualStyleBackColor = false;
            this.showdata.Click += new System.EventHandler(this.showdata_Click);
            // 
            // idGridView1
            // 
            this.idGridView1.DataPropertyName = "id";
            this.idGridView1.HeaderText = "ID";
            this.idGridView1.MinimumWidth = 8;
            this.idGridView1.Name = "idGridView1";
            this.idGridView1.Width = 150;
            // 
            // nameGridView2
            // 
            this.nameGridView2.DataPropertyName = "name";
            this.nameGridView2.HeaderText = "Name";
            this.nameGridView2.MinimumWidth = 8;
            this.nameGridView2.Name = "nameGridView2";
            this.nameGridView2.Width = 150;
            // 
            // surnameGridView3
            // 
            this.surnameGridView3.DataPropertyName = "surname";
            this.surnameGridView3.HeaderText = "Surname";
            this.surnameGridView3.MinimumWidth = 8;
            this.surnameGridView3.Name = "surnameGridView3";
            this.surnameGridView3.Width = 150;
            // 
            // salaryGridView4
            // 
            this.salaryGridView4.DataPropertyName = "salary";
            this.salaryGridView4.HeaderText = "Salary";
            this.salaryGridView4.MinimumWidth = 8;
            this.salaryGridView4.Name = "salaryGridView4";
            this.salaryGridView4.Width = 150;
            // 
            // addressGridView5
            // 
            this.addressGridView5.DataPropertyName = "address";
            this.addressGridView5.HeaderText = "Address";
            this.addressGridView5.MinimumWidth = 8;
            this.addressGridView5.Name = "addressGridView5";
            this.addressGridView5.Width = 150;
            // 
            // departmentGridView6
            // 
            this.departmentGridView6.DataPropertyName = "department";
            this.departmentGridView6.HeaderText = "Department ";
            this.departmentGridView6.MinimumWidth = 8;
            this.departmentGridView6.Name = "departmentGridView6";
            this.departmentGridView6.Width = 150;
            // 
            // EmailGridView7
            // 
            this.EmailGridView7.DataPropertyName = "emailaddress";
            this.EmailGridView7.HeaderText = "Email";
            this.EmailGridView7.MinimumWidth = 10;
            this.EmailGridView7.Name = "EmailGridView7";
            this.EmailGridView7.Width = 200;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 779);
            this.Controls.Add(this.showdata);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.employeetxt);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.deparmenttxt);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.surnametxt);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.salarytxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form4";
            this.Text = "Employee Management ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox surnametxt;
        private System.Windows.Forms.TextBox salarytxt;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.TextBox deparmenttxt;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.TextBox employeetxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Button showdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentGridView6;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailGridView7;
    }
}