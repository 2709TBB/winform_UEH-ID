﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CuoiKy.Program;

namespace winform_test
{
    public partial class FormRegister : Form
    {
        
        public FormRegister()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            string user, password, repassword, fullname, sex;
            int age;
            ulong id;

            try
            {
                user = boxUserRegister.Text;
                password = boxPassRegister.Text;
                repassword = boxReEnterPassRegister.Text;
                fullname = boxName.Text;
                age = int.Parse(boxAge.Text);
                id = ulong.Parse(boxId.Text);
                sex = boxSex.Text;
                BinarySearchTree binarytree = new BinarySearchTree();
                
                if (
                    password == repassword && user != null && password != null &&
                    repassword != null && fullname != null && age > 0 &&
                    id > 0 && sex != null && int.TryParse(boxAge.Text, out age) &&
                    id != null
                    )
                {
                    Account newAccount = new Account(user, password, fullname, sex, id, age);
                    GlobalData.BinarySearchTree.Insert(newAccount);
                    MessageBox.Show("Đã đăng ký thành công");
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                    this.Close();
                }
                else
                {                    
                    MessageBox.Show("Hãy kiểm tra lại thông tin!");                  
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy kiểm tra lại thông tin!");
            }
            
        }
        
    }
}
