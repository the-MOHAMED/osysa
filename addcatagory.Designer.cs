namespace WindowsFormsApplication2
{
    partial class frmdec
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDec = new System.Windows.Forms.TextBox();
            this.BTNSAVE = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Short_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmb_Name = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(401, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = " :اسم التصنيف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(361, 159);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = " :وصف التصنيف";
            // 
            // TxtDec
            // 
            this.TxtDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDec.Location = new System.Drawing.Point(49, 131);
            this.TxtDec.Multiline = true;
            this.TxtDec.Name = "TxtDec";
            this.TxtDec.Size = new System.Drawing.Size(284, 64);
            this.TxtDec.TabIndex = 1;
            // 
            // BTNSAVE
            // 
            this.BTNSAVE.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSAVE.Location = new System.Drawing.Point(49, 202);
            this.BTNSAVE.Name = "BTNSAVE";
            this.BTNSAVE.Size = new System.Drawing.Size(75, 30);
            this.BTNSAVE.TabIndex = 3;
            this.BTNSAVE.Text = "حفظ";
            this.BTNSAVE.UseVisualStyleBackColor = true;
            this.BTNSAVE.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 46);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::WindowsFormsApplication2.Properties.Resources.send;
            this.pictureBox3.Location = new System.Drawing.Point(556, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication2.Properties.Resources.text__1_;
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add Catagory";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.Txt_Short_Name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Cmb_Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtDec);
            this.groupBox1.Controls.Add(this.BTNSAVE);
            this.groupBox1.Location = new System.Drawing.Point(40, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(511, 238);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catagory";
            // 
            // Txt_Short_Name
            // 
            this.Txt_Short_Name.Location = new System.Drawing.Point(49, 93);
            this.Txt_Short_Name.Name = "Txt_Short_Name";
            this.Txt_Short_Name.Size = new System.Drawing.Size(284, 20);
            this.Txt_Short_Name.TabIndex = 7;
            this.Txt_Short_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Short_Name_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(357, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "تكويد التصنيف :";
            // 
            // Cmb_Name
            // 
            this.Cmb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cmb_Name.FormattingEnabled = true;
            this.Cmb_Name.Location = new System.Drawing.Point(49, 43);
            this.Cmb_Name.Name = "Cmb_Name";
            this.Cmb_Name.Size = new System.Drawing.Size(284, 24);
            this.Cmb_Name.TabIndex = 5;
            this.Cmb_Name.SelectedIndexChanged += new System.EventHandler(this.Cmb_Name_SelectedIndexChanged);
            this.Cmb_Name.Click += new System.EventHandler(this.Cmb_Name_Click);
            this.Cmb_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_Name_KeyDown);
            // 
            // frmdec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 349);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmdec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDec;
        private System.Windows.Forms.Button BTNSAVE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Cmb_Name;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox Txt_Short_Name;
        private System.Windows.Forms.Label label4;
    }
}