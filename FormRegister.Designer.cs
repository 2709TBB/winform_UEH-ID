namespace winform_test
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxAge = new System.Windows.Forms.TextBox();
            this.boxSex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.boxId = new System.Windows.Forms.TextBox();
            this.boxUserRegister = new System.Windows.Forms.TextBox();
            this.boxPassRegister = new System.Windows.Forms.TextBox();
            this.boxReEnterPassRegister = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxName
            // 
            this.boxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxName.Location = new System.Drawing.Point(136, 98);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(145, 20);
            this.boxName.TabIndex = 0;
            this.boxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // boxAge
            // 
            this.boxAge.Location = new System.Drawing.Point(136, 137);
            this.boxAge.Name = "boxAge";
            this.boxAge.Size = new System.Drawing.Size(145, 20);
            this.boxAge.TabIndex = 1;
            this.boxAge.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // boxSex
            // 
            this.boxSex.Location = new System.Drawing.Point(136, 176);
            this.boxSex.Name = "boxSex";
            this.boxSex.Size = new System.Drawing.Size(145, 20);
            this.boxSex.TabIndex = 2;
            this.boxSex.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập lại mật khẩu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(136, 358);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 6;
            this.Confirm.Text = "Đăng ký";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // boxId
            // 
            this.boxId.Location = new System.Drawing.Point(136, 215);
            this.boxId.Name = "boxId";
            this.boxId.Size = new System.Drawing.Size(145, 20);
            this.boxId.TabIndex = 7;
            // 
            // boxUserRegister
            // 
            this.boxUserRegister.Location = new System.Drawing.Point(136, 254);
            this.boxUserRegister.Name = "boxUserRegister";
            this.boxUserRegister.Size = new System.Drawing.Size(145, 20);
            this.boxUserRegister.TabIndex = 8;
            // 
            // boxPassRegister
            // 
            this.boxPassRegister.Location = new System.Drawing.Point(136, 293);
            this.boxPassRegister.Name = "boxPassRegister";
            this.boxPassRegister.Size = new System.Drawing.Size(145, 20);
            this.boxPassRegister.TabIndex = 9;
            this.boxPassRegister.UseSystemPasswordChar = true;
            // 
            // boxReEnterPassRegister
            // 
            this.boxReEnterPassRegister.Location = new System.Drawing.Point(136, 332);
            this.boxReEnterPassRegister.Name = "boxReEnterPassRegister";
            this.boxReEnterPassRegister.Size = new System.Drawing.Size(145, 20);
            this.boxReEnterPassRegister.TabIndex = 10;
            this.boxReEnterPassRegister.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Họ và tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tuổi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Số căn cước";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::winform_test.Properties.Resources.logo_dsa1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.boxName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Confirm);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.boxReEnterPassRegister);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.boxPassRegister);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.boxUserRegister);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.boxId);
            this.panel1.Controls.Add(this.boxAge);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.boxSex);
            this.panel1.Location = new System.Drawing.Point(362, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 476);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 549);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxAge;
        private System.Windows.Forms.TextBox boxSex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.TextBox boxId;
        private System.Windows.Forms.TextBox boxUserRegister;
        private System.Windows.Forms.TextBox boxPassRegister;
        private System.Windows.Forms.TextBox boxReEnterPassRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}