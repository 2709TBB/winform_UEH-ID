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
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void signOut_Click(object sender, EventArgs e)
        {
            // Trong mã của bạn, bạn có thể truy cập FormLogin thông qua lớp Application.
            FormLogin loginForm = null;

            // Lặp qua tất cả các form mà ứng dụng đang chạy
            foreach (Form form in Application.OpenForms)
            {
                // Kiểm tra xem form hiện tại có phải là FormLogin hay không
                if (form is FormLogin)
                {
                    loginForm = (FormLogin)form; // Ép kiểu form thành FormLogin
                    break; // Dừng vòng lặp nếu tìm thấy FormLogin
                }
            }       
            loginForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int searchID;
            if (!int.TryParse(SearchTextBox.Text, out searchID))
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
            FullnameLabel.Text = "Full Name: " + account.fullname;
            AgeLabel.Text = "Tuổi: " + account.age;
            SexLabel.Text = "Giới tính: " + account.sex;
            IdLabel.Text = "Số căn cước công dân: " + account.id;
        }

        private void AgeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
