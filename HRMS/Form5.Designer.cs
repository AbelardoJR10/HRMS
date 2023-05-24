namespace HRMS
{
    partial class Form5
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
            this.homebtn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewtextboxbtn = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showdatabtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.homebtn2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1449, 131);
            this.panel1.TabIndex = 1;
            // 
            // homebtn2
            // 
            this.homebtn2.Location = new System.Drawing.Point(1260, 33);
            this.homebtn2.Name = "homebtn2";
            this.homebtn2.Size = new System.Drawing.Size(146, 54);
            this.homebtn2.TabIndex = 2;
            this.homebtn2.Text = "Home";
            this.homebtn2.UseVisualStyleBackColor = true;
            this.homebtn2.Click += new System.EventHandler(this.homebtn2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(197, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "View employee";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::HRMS.Properties.Resources._656_6560404_icons8_staff_filled_1400_icon_hd_png_download;
            this.pictureBox1.InitialImage = global::HRMS.Properties.Resources._656_6560404_icons8_staff_filled_1400_icon_hd_png_download;
            this.pictureBox1.Location = new System.Drawing.Point(17, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(271, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee ID :";
            // 
            // viewtextboxbtn
            // 
            this.viewtextboxbtn.Location = new System.Drawing.Point(473, 208);
            this.viewtextboxbtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewtextboxbtn.Name = "viewtextboxbtn";
            this.viewtextboxbtn.Size = new System.Drawing.Size(307, 31);
            this.viewtextboxbtn.TabIndex = 5;
            this.viewtextboxbtn.TextChanged += new System.EventHandler(this.viewtextboxbtn_TextChanged);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(827, 196);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(177, 55);
            this.searchbtn.TabIndex = 6;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn1,
            this.nameColumn2,
            this.surnameColumn3,
            this.salaryColumn4,
            this.addressColumn5,
            this.departmentColumn6,
            this.EmailColumn7});
            this.dataGridView1.Location = new System.Drawing.Point(126, 378);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1147, 260);
            this.dataGridView1.TabIndex = 7;
            // 
            // idColumn1
            // 
            this.idColumn1.DataPropertyName = "id";
            this.idColumn1.HeaderText = "ID";
            this.idColumn1.MinimumWidth = 8;
            this.idColumn1.Name = "idColumn1";
            this.idColumn1.Width = 150;
            // 
            // nameColumn2
            // 
            this.nameColumn2.DataPropertyName = "name";
            this.nameColumn2.HeaderText = "Name";
            this.nameColumn2.MinimumWidth = 8;
            this.nameColumn2.Name = "nameColumn2";
            this.nameColumn2.Width = 150;
            // 
            // surnameColumn3
            // 
            this.surnameColumn3.DataPropertyName = "surname";
            this.surnameColumn3.HeaderText = "Surname";
            this.surnameColumn3.MinimumWidth = 8;
            this.surnameColumn3.Name = "surnameColumn3";
            this.surnameColumn3.Width = 150;
            // 
            // salaryColumn4
            // 
            this.salaryColumn4.DataPropertyName = "salary";
            this.salaryColumn4.HeaderText = "Salary";
            this.salaryColumn4.MinimumWidth = 8;
            this.salaryColumn4.Name = "salaryColumn4";
            this.salaryColumn4.Width = 150;
            // 
            // addressColumn5
            // 
            this.addressColumn5.DataPropertyName = "address";
            this.addressColumn5.HeaderText = "Address";
            this.addressColumn5.MinimumWidth = 8;
            this.addressColumn5.Name = "addressColumn5";
            this.addressColumn5.Width = 150;
            // 
            // departmentColumn6
            // 
            this.departmentColumn6.DataPropertyName = "department";
            this.departmentColumn6.HeaderText = "Department ";
            this.departmentColumn6.MinimumWidth = 8;
            this.departmentColumn6.Name = "departmentColumn6";
            this.departmentColumn6.Width = 150;
            // 
            // EmailColumn7
            // 
            this.EmailColumn7.DataPropertyName = "emailaddress";
            this.EmailColumn7.HeaderText = "Email";
            this.EmailColumn7.MinimumWidth = 10;
            this.EmailColumn7.Name = "EmailColumn7";
            this.EmailColumn7.Width = 200;
            // 
            // showdatabtn
            // 
            this.showdatabtn.Location = new System.Drawing.Point(1105, 314);
            this.showdatabtn.Name = "showdatabtn";
            this.showdatabtn.Size = new System.Drawing.Size(168, 57);
            this.showdatabtn.TabIndex = 8;
            this.showdatabtn.Text = "Show data";
            this.showdatabtn.UseVisualStyleBackColor = true;
            this.showdatabtn.Click += new System.EventHandler(this.showdatabtn_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 766);
            this.Controls.Add(this.showdatabtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.viewtextboxbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "Employee  & Deparment Database ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox viewtextboxbtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button homebtn2;
        private System.Windows.Forms.Button showdatabtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn7;
    }
}