namespace WindowsFormsApplication2
{
    partial class AddUser
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPasswordd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Chk_Pr_Edit = new System.Windows.Forms.CheckBox();
            this.Chk_Pr_Delete = new System.Windows.Forms.CheckBox();
            this.Dg9 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tid = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg9)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 50);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication2.Properties.Resources.send4;
            this.pictureBox3.Location = new System.Drawing.Point(471, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add  New User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.add_group;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password :";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(145, 108);
            this.TxtUser.Multiline = true;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(215, 25);
            this.TxtUser.TabIndex = 2;
            // 
            // TxtPasswordd
            // 
            this.TxtPasswordd.Location = new System.Drawing.Point(145, 152);
            this.TxtPasswordd.Multiline = true;
            this.TxtPasswordd.Name = "TxtPasswordd";
            this.TxtPasswordd.Size = new System.Drawing.Size(215, 25);
            this.TxtPasswordd.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Chk_Pr_Edit
            // 
            this.Chk_Pr_Edit.AutoSize = true;
            this.Chk_Pr_Edit.Location = new System.Drawing.Point(316, 183);
            this.Chk_Pr_Edit.Name = "Chk_Pr_Edit";
            this.Chk_Pr_Edit.Size = new System.Drawing.Size(44, 17);
            this.Chk_Pr_Edit.TabIndex = 4;
            this.Chk_Pr_Edit.Text = "Edit";
            this.Chk_Pr_Edit.UseVisualStyleBackColor = true;
            // 
            // Chk_Pr_Delete
            // 
            this.Chk_Pr_Delete.AutoSize = true;
            this.Chk_Pr_Delete.Location = new System.Drawing.Point(316, 199);
            this.Chk_Pr_Delete.Name = "Chk_Pr_Delete";
            this.Chk_Pr_Delete.Size = new System.Drawing.Size(57, 17);
            this.Chk_Pr_Delete.TabIndex = 4;
            this.Chk_Pr_Delete.Text = "Delete";
            this.Chk_Pr_Delete.UseVisualStyleBackColor = true;
            // 
            // Dg9
            // 
            this.Dg9.AllowUserToAddRows = false;
            this.Dg9.AllowUserToDeleteRows = false;
            this.Dg9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dg9.Location = new System.Drawing.Point(0, 291);
            this.Dg9.Name = "Dg9";
            this.Dg9.ReadOnly = true;
            this.Dg9.Size = new System.Drawing.Size(517, 300);
            this.Dg9.TabIndex = 5;
            this.Dg9.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg9_CellClick);
            this.Dg9.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg9_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 19);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tid
            // 
            this.tid.Location = new System.Drawing.Point(114, 310);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(19, 20);
            this.tid.TabIndex = 7;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 591);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Dg9);
            this.Controls.Add(this.Chk_Pr_Delete);
            this.Controls.Add(this.Chk_Pr_Edit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtPasswordd);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPasswordd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox Chk_Pr_Edit;
        private System.Windows.Forms.CheckBox Chk_Pr_Delete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView Dg9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tid;
    }
}