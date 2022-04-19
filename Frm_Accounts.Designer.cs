namespace WindowsFormsApplication2
{
    partial class Frm_Accounts
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
            this.button1 = new System.Windows.Forms.Button();
            this.Dg0 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Caed_Num = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassssss = new System.Windows.Forms.Label();
            this.txt_pa_ss = new System.Windows.Forms.TextBox();
            this.Cmb_Name_Acc = new System.Windows.Forms.ComboBox();
            this.txtpa = new System.Windows.Forms.TextBox();
            this.Txtlo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dg0)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Beige;
            this.button1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(209, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "حفظ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dg0
            // 
            this.Dg0.AllowUserToAddRows = false;
            this.Dg0.AllowUserToDeleteRows = false;
            this.Dg0.BackgroundColor = System.Drawing.Color.White;
            this.Dg0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg0.Location = new System.Drawing.Point(47, 213);
            this.Dg0.Name = "Dg0";
            this.Dg0.ReadOnly = true;
            this.Dg0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Dg0.Size = new System.Drawing.Size(888, 199);
            this.Dg0.TabIndex = 4;
            this.Dg0.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg0_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 50);
            this.panel1.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(53, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 36);
            this.label6.TabIndex = 34;
            this.label6.Text = "Accounts";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(118, 25);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(10, 20);
            this.txt_id.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Beige;
            this.button2.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(49, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 27);
            this.button2.TabIndex = 0;
            this.button2.Text = "حذف";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Beige;
            this.button3.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(129, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 27);
            this.button3.TabIndex = 0;
            this.button3.Text = "تعديل";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::WindowsFormsApplication2.Properties.Resources.cancel1;
            this.pictureBox2.Location = new System.Drawing.Point(956, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::WindowsFormsApplication2.Properties.Resources.send1;
            this.pictureBox3.Location = new System.Drawing.Point(923, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.account;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.txt_Caed_Num);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtpassssss);
            this.groupBox1.Controls.Add(this.txt_pa_ss);
            this.groupBox1.Controls.Add(this.Cmb_Name_Acc);
            this.groupBox1.Controls.Add(this.txtpa);
            this.groupBox1.Controls.Add(this.Txtlo);
            this.groupBox1.Location = new System.Drawing.Point(3, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 123);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txt_Caed_Num
            // 
            this.txt_Caed_Num.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_Caed_Num.Location = new System.Drawing.Point(10, 21);
            this.txt_Caed_Num.Name = "txt_Caed_Num";
            this.txt_Caed_Num.Size = new System.Drawing.Size(182, 23);
            this.txt_Caed_Num.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label4.Location = new System.Drawing.Point(198, 21);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "الرقم القومي للمسؤل :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label2.Location = new System.Drawing.Point(553, 61);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "كلمة سر المرتبات :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label1.Location = new System.Drawing.Point(892, 18);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "اسم العميل :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label3.Location = new System.Drawing.Point(890, 65);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "اسم الدخول :";
            // 
            // txtpassssss
            // 
            this.txtpassssss.AutoSize = true;
            this.txtpassssss.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.txtpassssss.Location = new System.Drawing.Point(573, 23);
            this.txtpassssss.Name = "txtpassssss";
            this.txtpassssss.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtpassssss.Size = new System.Drawing.Size(72, 25);
            this.txtpassssss.TabIndex = 3;
            this.txtpassssss.Text = "كلمة السر :";
            // 
            // txt_pa_ss
            // 
            this.txt_pa_ss.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pa_ss.Location = new System.Drawing.Point(337, 61);
            this.txt_pa_ss.Name = "txt_pa_ss";
            this.txt_pa_ss.Size = new System.Drawing.Size(212, 23);
            this.txt_pa_ss.TabIndex = 5;
            // 
            // Cmb_Name_Acc
            // 
            this.Cmb_Name_Acc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_Name_Acc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Name_Acc.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.Cmb_Name_Acc.FormattingEnabled = true;
            this.Cmb_Name_Acc.Location = new System.Drawing.Point(679, 16);
            this.Cmb_Name_Acc.Name = "Cmb_Name_Acc";
            this.Cmb_Name_Acc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_Name_Acc.Size = new System.Drawing.Size(212, 30);
            this.Cmb_Name_Acc.TabIndex = 1;
            this.Cmb_Name_Acc.SelectedIndexChanged += new System.EventHandler(this.Cmb_Name_Acc_SelectedIndexChanged);
            // 
            // txtpa
            // 
            this.txtpa.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpa.Location = new System.Drawing.Point(337, 23);
            this.txtpa.Name = "txtpa";
            this.txtpa.Size = new System.Drawing.Size(212, 23);
            this.txtpa.TabIndex = 2;
            // 
            // Txtlo
            // 
            this.Txtlo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtlo.Location = new System.Drawing.Point(678, 65);
            this.Txtlo.Name = "Txtlo";
            this.Txtlo.Size = new System.Drawing.Size(212, 23);
            this.Txtlo.TabIndex = 2;
            this.Txtlo.TextChanged += new System.EventHandler(this.Txtlo_TextChanged);
            // 
            // Frm_Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 424);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dg0);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Accounts";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Frm_Accounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dg0)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Cmb_Name_Acc;
        private System.Windows.Forms.TextBox txtpa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtpassssss;
        private System.Windows.Forms.DataGridView Dg0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtlo;
        private System.Windows.Forms.TextBox txt_pa_ss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_Caed_Num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}