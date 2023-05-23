namespace HRMS
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Logoutbutton2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.view = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.homebtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Logoutbutton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 72);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "HRMS";
            // 
            // Logoutbutton2
            // 
            this.Logoutbutton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.Logoutbutton2.FlatAppearance.BorderSize = 0;
            this.Logoutbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logoutbutton2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Logoutbutton2.Location = new System.Drawing.Point(918, 0);
            this.Logoutbutton2.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.Logoutbutton2.Name = "Logoutbutton2";
            this.Logoutbutton2.Size = new System.Drawing.Size(147, 70);
            this.Logoutbutton2.TabIndex = 2;
            this.Logoutbutton2.Text = "Log out";
            this.Logoutbutton2.UseVisualStyleBackColor = true;
            this.Logoutbutton2.Click += new System.EventHandler(this.Logoutbutton2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.view);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 78);
            this.panel2.TabIndex = 1;
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.SystemColors.Control;
            this.view.Dock = System.Windows.Forms.DockStyle.Right;
            this.view.FlatAppearance.BorderSize = 0;
            this.view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view.Location = new System.Drawing.Point(540, 0);
            this.view.Margin = new System.Windows.Forms.Padding(4);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(525, 76);
            this.view.TabIndex = 1;
            this.view.Text = "VIEW";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(532, 76);
            this.button2.TabIndex = 0;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.Red;
            this.homebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.homebtn.Location = new System.Drawing.Point(763, 0);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(124, 72);
            this.homebtn.TabIndex = 4;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Employee & Deparment ";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Logoutbutton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button homebtn;
    }
}