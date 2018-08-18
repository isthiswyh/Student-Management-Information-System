using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS
{
    public partial class FrmLogin : Form
    {
        static int i = 0;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Name1 = "teacher";
            string Password1 = "teacher";
            string name = "";
            string password = "";
            name = txtName.Text;
            password = txtpswd.Text;
            if ((name == Name1) && (password == Password1) && (i < 5))
            {
                Form1 frm1 = new Form1();
                this.Visible = false;
                frm1.ShowDialog();
                Close();
            }
            else
            {
                if (i < 5)
                {
                    MessageBox.Show("用户名或密码错误，请重新输入！");
                    i++;
                    txtName.Focus();
                }
                else
                {
                    MessageBox.Show("今天不能再登陆该系统！");
                    Close();
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblpswd_Click(object sender, EventArgs e)
        {

        }

        private void txtpswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
