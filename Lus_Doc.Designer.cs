namespace WindowsFormsApplication2
{
    partial class Lus_Doc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CmbNO = new System.Windows.Forms.ComboBox();
            this.CmbNAme = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dg10 = new System.Windows.Forms.DataGridView();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg10)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbNO
            // 
            this.CmbNO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbNO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbNO.BackColor = System.Drawing.Color.White;
            this.CmbNO.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.CmbNO.FormattingEnabled = true;
            this.CmbNO.Location = new System.Drawing.Point(1001, 249);
            this.CmbNO.Name = "CmbNO";
            this.CmbNO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbNO.Size = new System.Drawing.Size(248, 30);
            this.CmbNO.TabIndex = 17;
            this.CmbNO.SelectedIndexChanged += new System.EventHandler(this.CmbNO_SelectedIndexChanged);
            // 
            // CmbNAme
            // 
            this.CmbNAme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbNAme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbNAme.BackColor = System.Drawing.Color.White;
            this.CmbNAme.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.CmbNAme.FormattingEnabled = true;
            this.CmbNAme.Location = new System.Drawing.Point(1001, 202);
            this.CmbNAme.Name = "CmbNAme";
            this.CmbNAme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbNAme.Size = new System.Drawing.Size(248, 30);
            this.CmbNAme.TabIndex = 14;
            this.CmbNAme.SelectedIndexChanged += new System.EventHandler(this.CmbNAme_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(968, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 51);
            this.panel1.TabIndex = 15;
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
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.documents__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(5, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label3.Location = new System.Drawing.Point(1262, 249);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "نوع المستند :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label1.Location = new System.Drawing.Point(1258, 200);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "اسم العميل :";
            // 
            // IDA
            // 
            this.IDA.Font = new System.Drawing.Font("Sakkal Majalla", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDA.Location = new System.Drawing.Point(1001, 156);
            this.IDA.Name = "IDA";
            this.IDA.Size = new System.Drawing.Size(248, 26);
            this.IDA.TabIndex = 16;
            this.IDA.TextChanged += new System.EventHandler(this.IDA_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label2.Location = new System.Drawing.Point(1262, 156);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "كود العميل :";
            // 
            // Dg10
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Dg10.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Dg10.BackgroundColor = System.Drawing.Color.White;
            this.Dg10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg10.Dock = System.Windows.Forms.DockStyle.Left;
            this.Dg10.Location = new System.Drawing.Point(0, 0);
            this.Dg10.Name = "Dg10";
            this.Dg10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dg10.Size = new System.Drawing.Size(968, 641);
            this.Dg10.TabIndex = 10;
            this.Dg10.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg10_CellClick);
            this.Dg10.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg10_CellContentClick);
            // 
            // TxtCode
            // 
            this.TxtCode.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.TxtCode.Location = new System.Drawing.Point(1001, 292);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(248, 30);
            this.TxtCode.TabIndex = 18;
            this.TxtCode.TextChanged += new System.EventHandler(this.TxtCode_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label5.Location = new System.Drawing.Point(1262, 293);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "كود المستند :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label6.Location = new System.Drawing.Point(1271, 339);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "الفترة من :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label7.Location = new System.Drawing.Point(1111, 339);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(25, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "الي";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1145, 334);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 30);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(1001, 334);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(104, 30);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 30);
            this.label4.TabIndex = 24;
            this.label4.Text = "Review  Exported Doc";
            // 
            // Lus_Doc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1361, 641);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.CmbNO);
            this.Controls.Add(this.CmbNAme);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dg10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lus_Doc";
            this.Text = "Lus_Doc";
            this.Load += new System.EventHandler(this.Lus_Doc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbNO;
        private System.Windows.Forms.ComboBox CmbNAme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dg10;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
    }
}