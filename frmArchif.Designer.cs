namespace WindowsFormsApplication2
{
    partial class frmArchif
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtNamee = new System.Windows.Forms.Label();
            this.TxtFilee = new System.Windows.Forms.Label();
            this.TxtDess = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.TxtDes = new System.Windows.Forms.TextBox();
            this.CmbClientName = new System.Windows.Forms.ComboBox();
            this.CmbArchif = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Ofd = new System.Windows.Forms.OpenFileDialog();
            this.TxtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Txt_Notes = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Dg = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNamee
            // 
            this.TxtNamee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtNamee.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNamee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtNamee.Location = new System.Drawing.Point(463, 69);
            this.TxtNamee.Name = "TxtNamee";
            this.TxtNamee.Size = new System.Drawing.Size(91, 23);
            this.TxtNamee.TabIndex = 0;
            this.TxtNamee.Text = "أسم العميل :";
            // 
            // TxtFilee
            // 
            this.TxtFilee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtFilee.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFilee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtFilee.Location = new System.Drawing.Point(455, 111);
            this.TxtFilee.Name = "TxtFilee";
            this.TxtFilee.Size = new System.Drawing.Size(99, 23);
            this.TxtFilee.TabIndex = 1;
            this.TxtFilee.Text = "نوع المستند :";
            // 
            // TxtDess
            // 
            this.TxtDess.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtDess.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDess.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtDess.Location = new System.Drawing.Point(463, 155);
            this.TxtDess.Name = "TxtDess";
            this.TxtDess.Size = new System.Drawing.Size(91, 23);
            this.TxtDess.TabIndex = 2;
            this.TxtDess.Text = "وصف الملف :";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "مسار الرفع :";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.txtFilePath.Location = new System.Drawing.Point(50, 109);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(364, 30);
            this.txtFilePath.TabIndex = 5;
            this.txtFilePath.TextChanged += new System.EventHandler(this.TxtDown_TextChanged);
            // 
            // TxtDes
            // 
            this.TxtDes.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDes.Location = new System.Drawing.Point(53, 153);
            this.TxtDes.Name = "TxtDes";
            this.TxtDes.Size = new System.Drawing.Size(384, 30);
            this.TxtDes.TabIndex = 6;
            this.TxtDes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDes_KeyDown);
            // 
            // CmbClientName
            // 
            this.CmbClientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbClientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbClientName.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbClientName.FormattingEnabled = true;
            this.CmbClientName.Location = new System.Drawing.Point(53, 68);
            this.CmbClientName.Name = "CmbClientName";
            this.CmbClientName.Size = new System.Drawing.Size(384, 30);
            this.CmbClientName.TabIndex = 9;
            this.CmbClientName.SelectedIndexChanged += new System.EventHandler(this.CmbClientName_SelectedIndexChanged);
            this.CmbClientName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbClientName_KeyDown);
            // 
            // CmbArchif
            // 
            this.CmbArchif.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbArchif.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbArchif.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbArchif.FormattingEnabled = true;
            this.CmbArchif.Location = new System.Drawing.Point(53, 109);
            this.CmbArchif.Name = "CmbArchif";
            this.CmbArchif.Size = new System.Drawing.Size(384, 30);
            this.CmbArchif.TabIndex = 9;
            this.CmbArchif.SelectedIndexChanged += new System.EventHandler(this.ComFile_SelectedIndexChanged);
            this.CmbArchif.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbArchif_KeyDown);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(53, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(384, 30);
            this.txtID.TabIndex = 14;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Ofd
            // 
            this.Ofd.FileName = "Ofd";
            // 
            // TxtFileName
            // 
            this.TxtFileName.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.TxtFileName.Location = new System.Drawing.Point(50, 70);
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.Size = new System.Drawing.Size(363, 30);
            this.TxtFileName.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "أسم الملف :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(463, 29);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "كود العميل :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "تاريخ المستند :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.TxtDes);
            this.groupBox3.Controls.Add(this.CmbClientName);
            this.groupBox3.Controls.Add(this.CmbArchif);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.TxtDess);
            this.groupBox3.Controls.Add(this.TxtFilee);
            this.groupBox3.Controls.Add(this.TxtNamee);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(707, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(574, 213);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Client";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox4.Controls.Add(this.Txt_Notes);
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.TxtFileName);
            this.groupBox4.Controls.Add(this.txtFilePath);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.pictureBox4);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Location = new System.Drawing.Point(99, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(584, 213);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "File Description";
            // 
            // Txt_Notes
            // 
            this.Txt_Notes.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Notes.Location = new System.Drawing.Point(50, 151);
            this.Txt_Notes.Name = "Txt_Notes";
            this.Txt_Notes.Size = new System.Drawing.Size(364, 30);
            this.Txt_Notes.TabIndex = 24;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(50, 34);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(104, 30);
            this.dateTimePicker2.TabIndex = 21;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            this.dateTimePicker2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker2_KeyDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(309, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 30);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(168, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = " انتهاء الصلاحية :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(419, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "ملاحظات :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(99, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 38);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1381, 50);
            this.panel1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(74, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 36);
            this.label6.TabIndex = 1;
            this.label6.Text = "Archive";
            // 
            // Dg
            // 
            this.Dg.AllowUserToAddRows = false;
            this.Dg.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Dg.BackgroundColor = System.Drawing.Color.White;
            this.Dg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dg.Location = new System.Drawing.Point(0, 401);
            this.Dg.Name = "Dg";
            this.Dg.ReadOnly = true;
            this.Dg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Dg.Size = new System.Drawing.Size(1381, 315);
            this.Dg.TabIndex = 10;
            this.Dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.Dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(195, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 38);
            this.button1.TabIndex = 27;
            this.button1.Text = "تعديل";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::WindowsFormsApplication2.Properties.Resources.send;
            this.pictureBox3.Location = new System.Drawing.Point(1306, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::WindowsFormsApplication2.Properties.Resources.cancel;
            this.pictureBox2.Location = new System.Drawing.Point(1338, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.archive__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::WindowsFormsApplication2.Properties.Resources.file;
            this.pictureBox4.Location = new System.Drawing.Point(6, 78);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 53);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmArchif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1381, 716);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Dg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArchif";
            this.Text = "frmArchif";
            this.Load += new System.EventHandler(this.frmArchif_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TxtNamee;
        private System.Windows.Forms.Label TxtFilee;
        private System.Windows.Forms.Label TxtDess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox TxtDes;
        private System.Windows.Forms.ComboBox CmbArchif;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.OpenFileDialog Ofd;
        private System.Windows.Forms.TextBox TxtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbClientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView Dg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Notes;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}