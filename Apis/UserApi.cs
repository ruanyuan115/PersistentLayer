using System;
using System.Collections.Generic;
using System.Text;
using PersistentLayer.Mapper;

namespace PersistentLayer.Apis
{
    public class UserApi
    {
        public static UserInfo getByID(int? id)
        {
            return Global.db.Queryable<UserInfo>().InSingle(id);
        }
        public static List<UserInfo> getAll()
        {
            return Global.db.Queryable<UserInfo>().ToList();
        }
        public static int? insert(UserInfo userInfo)
        {
            return Global.db.Insertable(userInfo).ExecuteCommand();
        }
        public static int? update(UserInfo userInfo)
        {
            return Global.db.Updateable(userInfo).ExecuteCommand();
        }
        public static int? delete(int? id)
        {
            return Global.db.Deleteable<UserInfo>(id).ExecuteCommand();
        }
        public static UserInfo findByMail(string mail)
        {
            return (UserInfo)Global.db.Queryable<UserInfo>().Where(it => it.mail == mail);
        }
    }
}
