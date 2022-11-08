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

namespace Client
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        //SqlConnection conn = new SqlConnection(@"Data Source=MSI;Initial Catalog=DB_chat;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=HANKPHAM\SQLEXPRESS;Initial Catalog=DB_Chat;Integrated Security=True");
        
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Signin_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string pass = txbPass.Text;
            if (username == null || username.Equals(""))
            {
                MessageBox.Show("Username Empty!");
                txbUsername.Focus();

            }
            if (pass == null || pass.Equals(""))
            {
                MessageBox.Show("Password Empty!");
                txbPass.Focus();
            }
            conn.Open();
            string sql = "select * from [C_user] where Username='" + username + "' and Password='" + pass + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dt = cmd.ExecuteReader();
            if (dt.Read())
            {
                string Fullname = dt["Fullname"].ToString();
                FrmClient frM = new FrmClient(Fullname);
                frM.Show();// hiển thị from chính
                this.Hide();// ản from đăng nhập

            }
            else
            {
                MessageBox.Show("Username hoặc Password không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                return;

            }
        }

        private void btn_regis_Click(object sender, EventArgs e)
        {
            FrmRegis frmR = new FrmRegis();
            frmR.Show();
            this.Hide();
        }
    }
}
