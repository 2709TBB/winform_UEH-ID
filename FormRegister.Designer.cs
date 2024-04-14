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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxName
            // 
            this.boxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxName.Location = new System.Drawing.Point(181, 121);
            this.boxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(193, 22);
            this.boxName.TabIndex = 0;
            this.boxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // boxAge
            // 
            this.boxAge.Location = new System.Drawing.Point(181, 169);
            this.boxAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxAge.Name = "boxAge";
            this.boxAge.Size = new System.Drawing.Size(192, 22);
            this.boxAge.TabIndex = 1;
            this.boxAge.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // boxSex
            // 
            this.boxSex.Location = new System.Drawing.Point(181, 217);
            this.boxSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxSex.Name = "boxSex";
            this.boxSex.Size = new System.Drawing.Size(192, 22);
            this.boxSex.TabIndex = 2;
            this.boxSex.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 293);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 341);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 389);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập lại mật khẩu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(181, 441);
            this.Confirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(100, 28);
            this.Confirm.TabIndex = 6;
            this.Confirm.Text = "Đăng ký";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // boxId
            // 
            this.boxId.Location = new System.Drawing.Point(181, 265);
            this.boxId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxId.Name = "boxId";
            this.boxId.Size = new System.Drawing.Size(192, 22);
            this.boxId.TabIndex = 7;
            // 
            // boxUserRegister
            // 
            this.boxUserRegister.Location = new System.Drawing.Point(181, 313);
            this.boxUserRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxUserRegister.Name = "boxUserRegister";
            this.boxUserRegister.Size = new System.Drawing.Size(192, 22);
            this.boxUserRegister.TabIndex = 8;
            // 
            // boxPassRegister
            // 
            this.boxPassRegister.Location = new System.Drawing.Point(181, 361);
            this.boxPassRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxPassRegister.Name = "boxPassRegister";
            this.boxPassRegister.Size = new System.Drawing.Size(192, 22);
            this.boxPassRegister.TabIndex = 9;
            this.boxPassRegister.UseSystemPasswordChar = true;
            // 
            // boxReEnterPassRegister
            // 
            this.boxReEnterPassRegister.Location = new System.Drawing.Point(181, 409);
            this.boxReEnterPassRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxReEnterPassRegister.Name = "boxReEnterPassRegister";
            this.boxReEnterPassRegister.Size = new System.Drawing.Size(192, 22);
            this.boxReEnterPassRegister.TabIndex = 10;
            this.boxReEnterPassRegister.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Họ và tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tuổi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Số căn cước";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::winform_test.Properties.Resources.logo_dsa1;
            this.pictureBox1.Location = new System.Drawing.Point(16, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 75);
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
            this.panel1.Location = new System.Drawing.Point(456, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 586);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1193, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 676);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button button1;
    }
}