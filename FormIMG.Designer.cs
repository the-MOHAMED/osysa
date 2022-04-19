namespace WindowsFormsApplication2
{
    partial class FormIMG
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
            this.pictherBox12 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnLoadImg = new System.Windows.Forms.Button();
            this.Img = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).BeginInit();
            this.SuspendLayout();
            // 
            // pictherBox12
            // 
            this.pictherBox12.Location = new System.Drawing.Point(313, 50);
            this.pictherBox12.Multiline = true;
            this.pictherBox12.Name = "pictherBox12";
            this.pictherBox12.Size = new System.Drawing.Size(174, 26);
            this.pictherBox12.TabIndex = 0;
            this.pictherBox12.TextChanged += new System.EventHandler(this.pictherBox12_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(313, 95);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 30);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "عرض الصورة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(313, 131);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(84, 23);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnLoadImg
            // 
            this.BtnLoadImg.Location = new System.Drawing.Point(212, 301);
            this.BtnLoadImg.Name = "BtnLoadImg";
            this.BtnLoadImg.Size = new System.Drawing.Size(75, 41);
            this.BtnLoadImg.TabIndex = 14;
            this.BtnLoadImg.Text = "تحميل";
            this.BtnLoadImg.UseVisualStyleBackColor = true;
            this.BtnLoadImg.Click += new System.EventHandler(this.button3_Click);
            // 
            // Img
            // 
            this.Img.Location = new System.Drawing.Point(293, 189);
            this.Img.Name = "Img";
            this.Img.Size = new System.Drawing.Size(222, 165);
            this.Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img.TabIndex = 15;
            this.Img.TabStop = false;
            this.Img.Click += new System.EventHandler(this.Img_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "حفظ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 0;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormIMG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 447);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Img);
            this.Controls.Add(this.BtnLoadImg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictherBox12);
            this.Name = "FormIMG";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormIMG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pictherBox12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnLoadImg;
        private System.Windows.Forms.PictureBox Img;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}