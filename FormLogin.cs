﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CuoiKy.Program;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace winform_test
{
    public partial class FormLogin : Form
    {

        
        public FormLogin()
        {
            InitializeComponent();
        }

        public static ulong tempID = 0;

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string username = BoxUser.Text;
            string password = BoxPassword.Text;
            Account account = GlobalData.BinarySearchTree.SearchByUser(username);

            if (account != null && account.password == password)
            {
                Test test = new Test();
                tempID = account.id;
                test.Show();
                this.Hide();
                MessageBox.Show("Đăng nhập thành công!");
                
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không chính xác!");
            }
                              
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {          
            FormRegister formRegister = new FormRegister();       
            formRegister.Show();
            this.Hide();
        }
    }
}
