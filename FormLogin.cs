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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace winform_test
{
    public partial class FormLogin : Form
    {

        public class Account
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
        static List<Account> accounts = new List<Account>();
        public FormLogin()
        {
            InitializeComponent();
        }

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
            string username, password;
            username = BoxUser.Text;
            password = BoxPassword.Text;
            bool check = false;
            Account account = null;
            foreach (var acc in accounts)
            {
                if (acc.Username == username && acc.Password == password)
                {
                    account = acc;
                    check = true;
                    break;
                }                                                  
            }
            if (check == false)
                MessageBox.Show("Tài khoản không tồn tại");
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {          
            FormRegister formRegister = new FormRegister();       
            formRegister.Show();
            this.Close();

        }
    }
}
