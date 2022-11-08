using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Server
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        //SqlConnection conn = new SqlConnection(@"Data Source=MSI;Initial Catalog=DB_chat;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=HANKPHAM\SQLEXPRESS;Initial Catalog=DB_Chat;Integrated Security=True");
        private void btn_Signin_Click(object sender, EventArgs e)
        {
            string user = txbUsername.Text;
            string pass = txbPass.Text;
            if (user == null || user.Equals(""))
            {
                lblNotiUser.Text = "Username is Empty!";
                txbUsername.Focus();
            }
            else if (pass == null || pass.Equals(""))
            {
                lblNotiPas.Text = "Password is Empty!";
                txbPass.Focus();
            }
            conn.Open();
            string sql = " select * from[User] where Taikhoan= '" + user + "'and matkhau='" + pass + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dt = cmd.ExecuteReader();
            if (dt.Read())
            {
                //MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmServer frmM = new FrmServer();
                frmM.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Username hoặc Password không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                return;
            }

            

        }
    }
}
