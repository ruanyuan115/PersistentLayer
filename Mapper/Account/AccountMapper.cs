using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace PersistentLayer.Mapper.Account
{
    [SugarTable("USER_ACCOUNT")]
     class AccountMapper
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "ID")]
        public int Id { get; set; }

        [SugarColumn(ColumnName="USER_NAME")]
        public string Username { get; set; }

        [SugarColumn(ColumnName ="USER_PASSWORD")]
        public string Password { get; set; }

        [SugarColumn(ColumnName = "REGISTE_TIME")]
        public DateTime Registtime { get; set; }


        [SugarColumn(ColumnName = "MAIL")]
        public string Mail { get; set; }

        [SugarColumn(ColumnName = "PHONE")]
        public string Phone { get; set; }
    }
}
