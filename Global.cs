using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace PersistentLayer
{
    class Global
    {

        public static SqlSugarClient db
        {
            get
            {
                return createDb();
            }
        }
        private static SqlSugarClient createDb() {
            SqlSugarClient db = new SqlSugarClient(
                new ConnectionConfig()
                {
                    ConnectionString = "server=10.60.38.173;uid=root;pwd=123456;database=test2019",
                    DbType = DbType.MySql,//设置数据库类型
                    IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
                    InitKeyType = InitKeyType.Attribute //从实体特性中读取主键自增列信息
                });
            return db;
        }
    }
}
