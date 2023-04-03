using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Helper;

//using System.Windows.

namespace WndProc
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            DgvUser.AutoGenerateColumns = false;
        }
        Helper.UserHelper userHelper = new UserHelper();
        private void FrmMainn_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“userDataSet.UserTable”中。您可以根据需要移动或删除它。
            //this.userTableTableAdapter.Fill(this.userDataSet.UserTable);
            //SqlConnection conn = new SqlConnection();


            //string cstring = "Data Source=.;Initial Catalog=User;Integrated Security=True";
            //string connstring = "Data Source=.;Initial Catalog=User;Persist Security Info=True;User ID=sa;Password=123";
            //conn.ConnectionString = connstring;
            //conn.Open();

            //switch (conn.State)
            //{
            //    case ConnectionState.Open:
            //        {
            //            //MessageBox.Show(conn.State.ToString());
            //            string sql = "INSERT INTO UserTable ([UserNo],[CUserName],[CPassWord]) values('567','新的用户名','password')";
            //SqlCommand sqlCommand = new SqlCommand(sql, conn);
            //            int rows = sqlCommand.ExecuteNonQuery();
            //            if (rows > 0)
            //            {
            //                MessageBox.Show(rows.ToString());
            //            }
            //            break;
            //        }
            //}
            //conn.Close();
            SqlConnection
                con ;
            con = new SqlConnection("data source=.; database=User; integrated security=SSPI");
            con.Open();
            Console.WriteLine("建立与SQL Server数据库的连接成功~！");
            // 查询SQL Server 数据库的版本
            var cm = new SqlCommand("Select @@version as version", con);
            // Executing the SQL query  
            var sdr = cm.ExecuteReader();
            // Iterating Data  
            while (sdr.Read()) MessageBox.Show("SQL Server 数据库的版本是： " + sdr["version"]); // Displaying Record  
            
            
            InitDgv();
            InitDgv();
        }

        public void InitDgv()
        {
            DataTable dtUser = userHelper.GetQuery1();
            // (this.DgvUser).Refresh();

            DgvUser.DataSource = dtUser;
            DgvUser.ClearSelection();
        }
        private void openConnection(object sender, EventArgs e)
        {
            var connstring = "Data Source=.;Initial Catalog=User;Persist Security Info=True;User ID=sa;Password=123";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(connstring);
                con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        private void selectAll(object sender, EventArgs e)
        {
            List<UserInfo> infos = new List<UserInfo>();
            SqlConnection conn = new SqlConnection();
            string connstring = "Data Source=.;Initial Catalog=User;Persist Security Info=False;User ID=sa;Password=123;";
            conn.ConnectionString = connstring;
            string sql = "select * from UserTable";
            try
            {
                conn.Open();
                var cmd = new SqlCommand(sql, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                var resultString = "";
                while (sdr.Read())
                {
                    UserInfo userInfo = new UserInfo();
                    if (sdr.IsDBNull(0))
                        userInfo.UserNo = "空";
                    else
                        userInfo.UserNo = (string)sdr["UserNo"];

                    if (sdr.IsDBNull(1))
                        userInfo.UserName = "空";
                    else
                        userInfo.UserName = (string)sdr["CUserName"];

                    if (sdr.IsDBNull(2))
                        userInfo.Password = "空";
                    else
                        userInfo.Password = (string)sdr["CPassWord"];

                    if (sdr.IsDBNull(5))
                        userInfo.LoginTime = "空";
                    else
                        userInfo.LoginTime = sdr["CLoginTime"].ToString();

                    infos.Add(userInfo);
                    //box.Text += resultString;
                }
                DgvUser.DataSource = infos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void BindData()
        {
            var infos = new List<UserInfo>();
            var conn = new SqlConnection();
            var connstring = "Data Source=.;Initial Catalog=User;Persist Security Info=True;User ID=sa;Password=123";
            conn.ConnectionString = connstring;
            conn.Open();
            var sql = "select UserNo,CUserName,CPassWord,CLoginTime from UserTable";
            var cmd = new SqlCommand(sql, conn);
            var sdr = cmd.ExecuteReader();
        }


        private void sqldataadapter(object sender, EventArgs e)
        {
            var conn = new SqlConnection();
            var connstring = "Data Source=.;Initial Catalog=User;Persist Security Info=False;User ID=sa;Password=123;";

            conn.ConnectionString = connstring;
            conn.Open();
            var sql = "select * from UserTable";
            var cmd = new SqlCommand(sql);
            var sqll = new SqlDataAdapter();
            sqll.SelectCommand = cmd;
        }

        private void info_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("NewUserTable");
            DataColumn dc = new DataColumn();
            dt.Columns.Add(dc);
            MessageBox.Show(dt.Columns[0].ToString());
        }

        



















        
        private void TsBtnExit_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void TsBtnDel_Click(object sender, EventArgs e)
        {
            if (DgvUser.SelectedRows.Count<0)
            {
                return;
            }

            DataGridViewRow dr = DgvUser.SelectedRows[0];
            string str = dr.Cells["UserName"].ToString();

            if (MessageBox.Show("是否要删除 "+str, "确定要删除吗", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //todo 删除
                //wuhu ~
                
                
            }

            
        }

        public void TsBtnAdd_Click(object sender, EventArgs e)
        {
            FrmUserModel frmUserModel = new FrmUserModel(this);
            frmUserModel.Owner = this;
            frmUserModel.ShowDialog();
        }

        public static void GetUserData()
        {
            //todo 
            
        }
    }
}
