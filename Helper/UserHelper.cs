using System;
using System.Collections.Generic;
using Helper.Model;
using System.Data;
//using System.Data.
using System.Data.SqlClient;
using Helper.Model;


namespace Helper
{
    public class UserHelper
    {
        public bool Insert(DataRow drUser)
        {
            string cmdText =
                "INSERT INTO UserSheet(cUserCode,cUserName,cPassWord,cTelPhone,nRoleType,dLoginTime,cStats,cMemo)" +
                "VALUES('" + drUser["UserNo"] + "','" +
                drUser["cUserName"] + "','" +
                drUser["cPassWord"] + "','" +
                drUser["cTelPhone"] + "'," +
                drUser["nRoleType"] + ",'" +
                drUser["cLoginTime"] + "','" +
                drUser["cStatus"] + "','" +
                drUser["cMemo"] + "'";
            int nRow = SqlHelper.ExecCmd(cmdText, null, null);
            return nRow > 0;
        }

        public bool Insert(Model.SysUser user)
        {
            user.UserNo = GetUserNo(user);
            string cmdText =
                "INSERT INTO dbo.UserTable(UserNo,cUserName,cPassWord,cTelPhone,nRoleType,cLoginTime,cStatus,cMemo)" +
                "VALUES(@UserNo,@cUserName,@cPassWord,@cTelPhone,@nRoleType,@cLoginTime,@cStatus,@cMemo)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@UserNo", user.UserNo),
                new SqlParameter("@cUserName", user.CUserName),
                new SqlParameter("@cPassWord", user.CPassWord),
                new SqlParameter("@cTelPhone", user.CTelPhone),
                new SqlParameter("@nRoleType", user.NRoleType),
                new SqlParameter("@cLoginTime", user.CLoginTime),
                new SqlParameter("@cStatus", user.CStatus),
                new SqlParameter("@cMemo", user.CMemo)
            };
            if (SqlHelper.ExecCmd(cmdText, param) > 0)
            {
                return true;
            }

            return false;
        }

        private string GetUserNo(SysUser user)
        {
            // string cFilter = "nRoleType= " + user.NRoleType;

            string cmdTxt = @"select max(UserNo) from UserTable where nRoleType="+user.NRoleType;
            string cMaxNo = SqlHelper.GetObject(cmdTxt).ToString();
            if (cMaxNo.Length == 0)
            {
                cMaxNo = user.NRoleType > 1 ? "u02001" : "a01001";
            }
            
            else
            {
                //todo
                int nCode = int.Parse(cMaxNo.Substring(3));
                cMaxNo = cMaxNo.Substring(0, 3) + (nCode + 1).ToString().PadLeft(3, '0');

            }

            // cMaxNo = cMaxNo.Substring(0, 3) + (nCode + 1).ToString().PadLeft(3, '0');


            // Convert.ToBoolean()
            // throw new NotImplementedException();
            // return string.Empty;
            return cMaxNo;
            // string str1 = string.Empty;   
            // string str = string.Empty;
        }

        public int Update(Model.SysUser user)
        {
            // string cmdText = "UPDATE UserTable  SET " +
            //                  " cUserName = @cUserName, " +
            //                  " cPassWord = @cPassWord," +
            //                  " cTelPhone = @cTelPhone, " +
            //                  " nRoleType = @nRoleType," +
            //                  " dLoginTime = @dLoginTime, " +
            //                  " cStats =@cStats," +
            //                  " cMemo = @Memo " +
            //                  " where cUserCode = @cUserCode,";

            
            string cmdText = "UPDATE dbo.UserTable SET "+
                             "cUserName = @cUserName," +
                             "cPassWord = @cPassWord," +
                             "cTelPhone = @cTelPhone," +
                             "nRoleType = @nRoleType," +
                             "cLoginTime = @cLoginTime," +
                             "cStatus = @cStatus," +
                             "cMemo where UserNo = @cUserNo";
            // string txt = "UPDATE dbo.UserTable SET cUserName = @cUserName,cPassWord = @cPassWord,cTelPhone = @cTelPhone,nRoleType = @nRoleType,cLoginTime = @cLoginTime,cStatus = @cStatus, cMemo where UserNo = @cUserNo";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@cUserNo", user.UserNo),
                new SqlParameter("@cUserName", user.CUserName),
                new SqlParameter("@cPassWord", user.CPassWord),
                new SqlParameter("@cTelPhone", user.CTelPhone),
                new SqlParameter("@nRoleType", user.NRoleType),
                new SqlParameter("@cLoginTime", user.CLoginTime),
                new SqlParameter("@cStatus", user.CStatus),
                new SqlParameter("@cMemo", user.CMemo)
            };
            int nrow = SqlHelper.ExecCmd(cmdText, param, null);
            return nrow;
        }

        public int Delete(string cFilter = "")
        {
            string cmdText = "DELETE FROM dbo.UserTable ";
            if (cFilter.Length > 0)
            {
                cmdText += "where" + cFilter;
            }

            int nrows = SqlHelper.ExecCmd(cmdText, null, null);
            return nrows;
        }

        public int DeleteByNo(string UserNo)
        {
            string cFilter = "UserNo '" + UserNo + "'";
            return Delete(cFilter);
        }

        //public int DeleteBy


        public SysUser GetUserByName(string cUserName)
        {
            //string cmdText1 = "select * from UserTable where cUserName" + "'" + cUserName + "'";
            string cmdText = "select * from UserTable where cUserName = @cUserName ";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@cUserName", cUserName),
            };
            DataTable dtUser = SqlHelper.GetTable(cmdText: cmdText, param, null);
            // List<Model.SysUser> lstuser = new List<SysUser>();
            // foreach (DataRow dr in dtUser.Rows)
            // {
            //     Model.SysUser user = GetModelByRow(dr);
            //     lstuser.Add(user);
            // }

            if (dtUser.Rows.Count > 0)
            {
                return GetModelByRow(dtUser.Rows[0]);
            }

            return null;
            //Model.SysUser user = new SysUser();
            //if (dtUser.Rows.Count > 0)
            //{
            //    //return dtUser.
            //    user.UserNo = dtUser.Rows[0]["UserNo"].ToString();
            //    user.CUserName = dtUser.Rows[0]["CUserName"].ToString();
            //    user.CPassWord = dtUser.Rows[0]["CPassWord"].ToString();


            //    //user.CTelPhone = dtUser.Rows[0]["CTelPhone"].ToString();
            //    //user.NRoleType = Convert.ToInt32(dtUser.Rows[0]["nRoleType"]);
            //    //user.CLoginTime = Convert.ToDateTime(dtUser.Rows[0]["CLoginTime"]);
            //    //user.CStatus = dtUser.Rows[0]["CStatus"].ToString();
            //    //user.CMemo = dtUser.Rows[0]["CMemo"].ToString();
            //    return user;
            //}

            return null;
        }

        //public void GetModelByRow(DataRow dr)
        public Model.SysUser GetModelByRow(DataRow dr)
        {
            //todo GetModelByName
            if (dr != null)
            {
                Model.SysUser user = new SysUser();
                //user.UserNo = dr["UserNo"].ToString();
                user.UserNo = dr["UserNo"].ToString();
                user.CUserName = dr["cUserName"].ToString();
                user.CPassWord = dr["cPassWord"].ToString();
                user.CTelPhone = dr["cTelPhone"].ToString();
                //判断用户角色在数据库中的值是否为空 DBNull
                user.NRoleType = dr["nRoleType"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(dr["nRoleType"]);
                //user.NRoleType = Convert.ToInt32(dr["nRoleType"].ToString());
                user.CLoginTime = Convert.ToDateTime(dr["cLoginTime"]);
                user.CStatus = dr["cStatus"].ToString();
                user.CMemo = dr["cMemo"].ToString();
                return user;
            }


            return null;
        }

        public List<SysUser> GetUserByName1(string cFilter = "")
        {
            //string cmdText1 = "select * from UserTable where cUserName" + "'" + cUserName + "'";
            string cmdText = "select * from UserTable where cUserName = @cUserName ";
            //SqlParameter[] param = new SqlParameter[]
            //{
            //    new SqlParameter("@cUserName", cUserName),
            //};
            DataTable dtUser = SqlHelper.GetTable(cmdText: cmdText, null, null);
            if (dtUser == null)
            {
                return null;
            }

            List<Model.SysUser> lstuser = new List<SysUser>();
            foreach (DataRow dr in dtUser.Rows)
            {
                Model.SysUser user = GetModelByRow(dr);
                lstuser.Add(user);
            }

            return lstuser;
        }


        public void test(string cUserName)
        {
        }

        public DataTable GetQuery(string cFilter = "")
        {
            string cmdText = "Select * From UserTable";
            string cmdtxt = "select UserNo,cUserName,cTelPhone,nRoleType,cLoginTime,cMemo " +
                            "case when cStatus = '1' then '正常' as cStatus  from UserTable;";
            if (cFilter.Length > 0)
            {
                cmdText += " where " + cFilter;
            }

            DataTable dtUser = SqlHelper.GetTable(cmdText, null, null);

            return dtUser;
        }

        public DataTable GetQuery1(string cFilter = "")
        {
            string cmdText = "select UserNo,cUserName,cTelPhone,cLoginTime,cMemo," +
                             "case when cStatus = '1' then '正常' else '停用' end as Status , " +
                             "case when nRoleType = '1' then '管理员' else '普通用户' end as nRoleType " +
                             "from UserTable";
            if (cFilter.Length > 0)
            {
                cmdText += " where " + cFilter;
            }

            DataTable dtUser = SqlHelper.GetTable(cmdText, null, null);

            return dtUser;
        }
    }
}