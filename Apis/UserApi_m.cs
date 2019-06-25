using System;
using System.Collections.Generic;
using System.Text;
using PersistentLayer.Mapper;

namespace PersistentLayer.Apis
{
    public class UserApi_m
    {
        public static List<UserInfo> findByUserID(List<int> userIDs)
        {
            foreach (int i in userIDs)
            {
                Global.db.Queryable<UserInfo>().Where(it=>it.userID==i).AddQueue();
            }
            var result = Global.db.SaveQueues<UserInfo>();//打包查询
            return result;
        }
    }
}
