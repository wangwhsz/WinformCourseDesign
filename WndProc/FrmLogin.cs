using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Helper;
using Helper.Model;

namespace WndProc
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.Cancel;
            Close();
            Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserHelper userHelper = new UserHelper();
            //FrmMainn frmMainn = new FrmMainn();
            //frmMainn.Show();
            //Hide();


            //#region 

            string cUserName = txtName.Text.Trim();
            
            string cPwd = txtPswd.Text.Trim();
            Helper.Model.SysUser user  = userHelper.GetUserByName(cUserName);
            if (user != null)
            {
                string cPassword = user.CPassWord;
                if (cPwd.Equals(cPassword))
                {
                    MessageBox.Show("登录成功");
                }
                else
                {
                    MessageBox.Show("密码错误 登录失败");
                    txtPswd.Focus();
                    txtPswd.SelectAll();
                    return;
                }
            }
            else
            {
                MessageBox.Show("没有该用户！");
                txtName.Focus();
                txtName.SelectAll();
                return;
            }






            //if (dtUser.Rows.Count>0)
            ////if (sdr.Read())
            //{
            //    string pswd = dtUser.Rows[0]["cPassword"].ToString();
            //    if (pswd.Equals(cPassWord))
            //    {
            //        MessageBox.Show("登录成功");
            //    }
            //    else
            //    {
            //        MessageBox.Show("密码错误 登录失败");
            //        txtPswd.Focus();
            //        txtPswd.SelectAll();
            //        return;
            //    }







            //    //string password = sdr["CPassWord"].ToString();
            //    //if (password.Equals(CPassWord))
            //    //{
            //    //    MessageBox.Show("yes");

            //    //}
            //    //else
            //    //{
            //    //    MessageBox.Show("no");
            //    //}
            //}
            //else
            //{
            //    MessageBox.Show("没有该用户");
            //    txtName.Focus();
            //    txtName.SelectAll();
            //    return;
            //}

            //con.Close();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}