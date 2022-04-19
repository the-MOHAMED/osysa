namespace WindowsFormsApplication2
{
    partial class frmuploadfile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dg2 = new System.Windows.Forms.DataGridView();
            this.Ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdi = new System.Windows.Forms.TextBox();
            this.CmbN = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dg2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dg2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Dg2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dg2.BackgroundColor = System.Drawing.Color.White;
            this.Dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Dg2.Location = new System.Drawing.Point(0, 0);
            this.Dg2.Name = "Dg2";
            this.Dg2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Dg2.Size = new System.Drawing.Size(968, 680);
            this.Dg2.TabIndex = 0;
            this.Dg2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg2_CellClick);
            this.Dg2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg2_CellContentClick);
            // 
            // Ofd1
            // 
            this.Ofd1.FileName = "Ofd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label1.Location = new System.Drawing.Point(1258, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "اسم العميل :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(968, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 51);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::WindowsFormsApplication2.Properties.Resources.send1;
            this.pictureBox3.Location = new System.Drawing.Point(356, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.documents;
            this.pictureBox1.Location = new System.Drawing.Point(5, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(66, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Review documents";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtdi
            // 
            this.txtdi.Font = new System.Drawing.Font("Sakkal Majalla", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdi.Location = new System.Drawing.Point(1001, 156);
            this.txtdi.Name = "txtdi";
            this.txtdi.Size = new System.Drawing.Size(248, 26);
            this.txtdi.TabIndex = 8;
            // 
            // CmbN
            // 
            this.CmbN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbN.BackColor = System.Drawing.Color.White;
            this.CmbN.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbN.FormattingEnabled = true;
            this.CmbN.Location = new System.Drawing.Point(1001, 202);
            this.CmbN.Name = "CmbN";
            this.CmbN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbN.Size = new System.Drawing.Size(248, 30);
            this.CmbN.TabIndex = 7;
            this.CmbN.SelectedIndexChanged += new System.EventHandler(this.CmbN_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label2.Location = new System.Drawing.Point(1259, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "كود العميل :";
            // 
            // Cmb1
            // 
            this.Cmb1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb1.BackColor = System.Drawing.Color.White;
            this.Cmb1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.Cmb1.FormattingEnabled = true;
            this.Cmb1.Location = new System.Drawing.Point(1001, 249);
            this.Cmb1.Name = "Cmb1";
            this.Cmb1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb1.Size = new System.Drawing.Size(248, 30);
            this.Cmb1.TabIndex = 9;
            this.Cmb1.SelectedIndexChanged += new System.EventHandler(this.Cmb1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label3.Location = new System.Drawing.Point(1262, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "نوع المستند :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(1001, 340);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(104, 30);
            this.dateTimePicker2.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1145, 340);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 30);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // TxtCode
            // 
            this.TxtCode.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.TxtCode.Location = new System.Drawing.Point(1001, 299);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(248, 30);
            this.TxtCode.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label7.Location = new System.Drawing.Point(1111, 345);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(25, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "الي";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label6.Location = new System.Drawing.Point(1271, 345);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "الفترة من :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label5.Location = new System.Drawing.Point(1262, 299);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "كود المستند :";
            // 
            // frmuploadfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1377, 680);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cmb1);
            this.Controls.Add(this.CmbN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dg2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmuploadfile";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "..";
            this.Load += new System.EventHandler(this.frmuploadfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dg2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dg2;
        private System.Windows.Forms.OpenFileDialog Ofd1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CmbN;
        private System.Windows.Forms.TextBox txtdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cmb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}