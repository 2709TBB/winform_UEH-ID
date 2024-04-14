using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CuoiKy.Program;

namespace winform_test
{
    public partial class Test : Form
    {
        
        public Test()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#AFEEEE");
            FormEdit.CustomizeForm(this);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Account loginaccout = GlobalData.BinarySearchTree.SearchById(FormLogin.tempID);
            ShowUserInfo(loginaccout);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void signOut_Click(object sender, EventArgs e)
        {
            
            FormLogin loginForm = null;

            
            foreach (Form form in Application.OpenForms)
            {
                
                if (form is FormLogin)
                {
                    loginForm = (FormLogin)form; 
                    break; 
                }
            }       
            loginForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong searchID;
            if (!ulong.TryParse(SearchTextBox.Text, out searchID))
            {
                MessageBox.Show("Vui lòng nhập một ID hoặc số căn cước hợp lệ.");
                return;
            }

            
            Account foundAccount = GlobalData.BinarySearchTree.SearchById(searchID);

            
            if (foundAccount != null)
            {
                ShowUserInfo(foundAccount);
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng với ID hoặc số căn cước đã nhập.");
            }
        }

        private void ShowUserInfo(Account account)
        {
            UsernameLabel.Text = "Username: " + account.username;
            FullnameLabel.Text = "Họ và Tên: " + account.fullname;
            AgeLabel.Text = "Tuổi: " + account.age;
            SexLabel.Text = "Giới tính: " + account.sex;
            IdLabel.Text = "Số căn cước công dân: " + account.id;
        }

        private void AgeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BinarySearchTree exit = new BinarySearchTree();
            exit.ExitApp();
        }
    }
}
