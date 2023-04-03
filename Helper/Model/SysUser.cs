using System;
using System.Data;

namespace Helper.Model
{
    public class SysUser
    {
        public string UserNo { get; set; }

        public string CUserName { get; set; }

        public string CPassWord { get; set; }

        public string CTelPhone { get; set; }

        public int NRoleType { get; set; }

        public DateTime CLoginTime { get; set; }

        public string CStatus { get; set; }
        public string CMemo { get; set; }
    }
}