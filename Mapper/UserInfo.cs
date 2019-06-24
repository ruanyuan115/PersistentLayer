using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace PersistentLayer.Mapper
{
    [SugarTable("user")]
    public class UserInfo
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "user_id")]
        public int userID { set; get; }
        [SugarColumn(ColumnName = "mail")]
        public string mail { set; get; }
        [SugarColumn(ColumnName = "password")]
        public string password { set; get; }
        [SugarColumn(ColumnName = "name")]
        public string name { set; get; }
        [SugarColumn(ColumnName = "role")]
        public string role { set; get; }
        [SugarColumn(ColumnName = "work_id")]
        public int workID { set; get; }
        [SugarColumn(ColumnName = "gender")]
        public string gender { set; get; }

        public UserInfo() { }
        public UserInfo(UserInfo userInfo)
        {
            this.userID = userInfo.userID;
            this.mail = userInfo.mail;
            this.name = userInfo.name;
            this.role = userInfo.role;
            this.workID = userInfo.workID;
            this.gender = userInfo.gender;
        }
    }
}
