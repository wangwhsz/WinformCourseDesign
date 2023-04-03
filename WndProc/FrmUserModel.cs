using System;
using System.Data;
using System.Windows.Forms;
using Helper;
using Helper.Model;

namespace WndProc
{
    public partial class FrmUserModel : Form
    {
        
        public FrmMain _frmMain;
        public FrmUserModel(FrmMain frmMain)
        {
            _frmMain = frmMain;
            InitializeComponent();
        }

        Helper.UserHelper helper = new UserHelper();

        public void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                txtName.Focus();
                MessageBox.Show("该项为空！");
                return;
            }

            if (txtPswd.Text.Length == 0)
            {
                txtPswd.Focus();
                MessageBox.Show("该项为空！");

                return;
            }

            if (txtTel.Text.Length == 0)
            {
                txtTel.Focus();
                MessageBox.Show("该项为空！");

                return
                    ;
            }
            //todo 判空 username userno tel
            string cPwd = txtPswd.Text.Trim();
            if (cPwd.Equals(txtPswdAg.Text.Trim())==false)
            {
                txtPswdAg.Focus();
                MessageBox.Show("两次密码不相同");
                return;
            }
            SysUser user = new Helper.Model.SysUser();
            user.CUserName = txtName.Text.Trim();
            user.CPassWord = txtPswd.Text.Trim();
            user.CTelPhone = txtTel.Text.Trim();
            //user.CUserName = txtName.Text.Trim();
            user.CStatus = chkStatus.Checked ? "0" : "1";
            // asldjh

            user.NRoleType = comboBoxType.SelectedIndex + 1;
            user.CLoginTime = DateTime.Now;
            user.CMemo = txtMemo.Text;
            Boolean bol;
            bol = helper.Insert(user);
            if (bol==true)
            {
                MessageBox.Show("新建用户成功");
                DataTable dtUser = helper.GetQuery1();
                _frmMain.DgvUser.DataSource = dtUser;
                
                    //todo 
            }
            else
            {
                MessageBox.Show("fail");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void FrmUserModel_FormClosed(object sender, FormClosedEventArgs e)
        {
            // this.Parent
            // ].InitDgv();
        }

        private void FrmUserModel_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frmMain.InitDgv();
            // _frmMain.DgvUser.Refresh();
            // _frmMain.Load();
            DataTable dtUser = helper.GetQuery1();
            _frmMain.DgvUser.DataSource = dtUser;

        }
    }
}
