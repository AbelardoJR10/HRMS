namespace HRMS
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logoutbutton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.employeesbtn = new System.Windows.Forms.Button();
            this.departmentsbtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.Logoutbutton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 146);
            this.panel1.TabIndex = 0;
            // 
            // Logoutbutton1
            // 
            this.Logoutbutton1.FlatAppearance.BorderSize = 0;
            this.Logoutbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logoutbutton1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Logoutbutton1.Location = new System.Drawing.Point(1019, 43);
            this.Logoutbutton1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Logoutbutton1.Name = "Logoutbutton1";
            this.Logoutbutton1.Size = new System.Drawing.Size(213, 60);
            this.Logoutbutton1.TabIndex = 1;
            this.Logoutbutton1.Text = "Log out";
            this.Logoutbutton1.UseVisualStyleBackColor = true;
            this.Logoutbutton1.Click += new System.EventHandler(this.Logoutbutton1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(73, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "HRMS";
            // 
            // employeesbtn
            // 
            this.employeesbtn.BackColor = System.Drawing.Color.Red;
            this.employeesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesbtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.employeesbtn.Location = new System.Drawing.Point(280, 270);
            this.employeesbtn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.employeesbtn.Name = "employeesbtn";
            this.employeesbtn.Size = new System.Drawing.Size(213, 138);
            this.employeesbtn.TabIndex = 1;
            this.employeesbtn.Text = "Employees";
            this.employeesbtn.UseVisualStyleBackColor = false;
            this.employeesbtn.Click += new System.EventHandler(this.employeesbtn_Click);
            // 
            // departmentsbtn
            // 
            this.departmentsbtn.BackColor = System.Drawing.Color.Red;
            this.departmentsbtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.departmentsbtn.Location = new System.Drawing.Point(685, 270);
            this.departmentsbtn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.departmentsbtn.Name = "departmentsbtn";
            this.departmentsbtn.Size = new System.Drawing.Size(213, 138);
            this.departmentsbtn.TabIndex = 3;
            this.departmentsbtn.Text = "Departments";
            this.departmentsbtn.UseVisualStyleBackColor = false;
            this.departmentsbtn.Click += new System.EventHandler(this.departmentsbtn_Click);
            // 
            // button5
            // 
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.Image = global::HRMS.Properties.Resources.download2;
            this.button5.Location = new System.Drawing.Point(1142, 491);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 70);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 585);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.departmentsbtn);
            this.Controls.Add(this.employeesbtn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form2";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Logoutbutton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button employeesbtn;
        private System.Windows.Forms.Button departmentsbtn;
        private System.Windows.Forms.Button button5;
    }
}