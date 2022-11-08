using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmRegis : Form
    {
        AccessData acc;
        public FrmRegis()
        {
            InitializeComponent();
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            string user = txbUs.Text;
            string Fullname = txbName.Text;
            string pass = txbPass.Text;
            string Cpass = txbCpass.Text;
            int n;
            acc = new AccessData();
            string sql = "insert into [C_user] values('" + user + "','" + Fullname + "','" + pass + "','" + Cpass + "')";
            if (user == null || user.Equals(""))
            {
                lblNoiUs.Text = "Enter Username";
                txbUs.Focus();
            }
            else if (Fullname == null || Fullname.Equals(""))
            {
                lblNoiName.Text = "Enter full name!";
                txbName.Focus();
            }
            else if (pass == null || pass.Equals(""))
            {
                lblNoiPas.Text = "Enter a password!";
                txbPass.Focus();
            }
            else if (Cpass != pass)
            {
                try
                {
                    n = int.Parse(user);
                }
                catch (Exception)
                {

                    lblNoiUs.Text = "Enter a phone number!";
                    txbUs.Focus();
                    txbUs.SelectAll();

                }

                lblNoiCpass.Text = "Those password didn't match. Try again";
                txbCpass.Focus();
                txbCpass.SelectAll();
                return;

            }
            else
            {
                try
                {
                    n = int.Parse(user);
                }
                catch (Exception)
                {

                    lblNoiUs.Text = "Enter a phone number!";
                    txbUs.Focus();
                    txbUs.SelectAll();

                }
                acc.ExcuteNonQuery(sql);// thuc thi query
                MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmClient frM = new FrmClient(Fullname);
                frM.Show();
                this.Hide();
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            FrmLogin frmL = new FrmLogin();
            frmL.Show();
            this.Hide();
        }

        private void txbUs_TextChanged(object sender, EventArgs e)
        {
            acc = new AccessData();
            int n;
            SqlDataReader dr = acc.ExecuteReader("select Username from [C_user]");

            try
            {
                n = int.Parse(txbUs.Text);
            }
            catch (Exception)
            {

                lblNoiUs.Text = "Enter a phone number!";
                txbUs.Focus();
                txbUs.SelectAll();

            }
            while (dr.Read())
            {
                if (dr["Username"].ToString().ToUpper() == txbUs.Text.ToUpper())
                {
                    lblNoiUs.Text = "That username is taken.Try another!";
                    txbUs.SelectAll();
                }
            }
        }
    }
}
