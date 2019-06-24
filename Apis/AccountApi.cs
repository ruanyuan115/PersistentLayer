using System;
using System.Collections.Generic;
using System.Text;
using PersistentLayer.Mapper.Account;
using System.Threading.Tasks;
using System.Threading;

namespace PersistentLayer.Apis
{
    public class AccountApi
    {

        public async static Task<bool>  IsUsedUsernameAsync(string username) {

            int count = await Task<int>.Run(() =>
            {
                //Thread.Sleep(1000); 测试异步
                return Global.db.Queryable<AccountMapper>().Where(x => x.Username == username).Count();
            });

            if (count!=0) {
                return true;
            }

            return false;
        }

        public async static Task<bool> IsUsedPhoneAsync(string phone) {
            int count = await Task<int>.Run(() =>
            {
                return Global.db.Queryable<AccountMapper>().Where(x => x.Phone == phone).Count();
            });

            if (count != 0) {
                return true;
            }

            return false;
        }

        public async static Task<bool> IsUsedMailAsync(string mail) {
            int count = await Task<int>.Run(() =>
            {
                return Global.db.Queryable<AccountMapper>().Where(x => x.Mail == mail).Count();
            });

            if (count != 0) {
                return true;
            }

            return false;
        }

        public static bool Register(string username,string password,string mail,string phone) {
            AccountMapper account = new AccountMapper();
            account.Username = username;
            account.Password = password;
            account.Mail = mail.Equals("") ? "EMPTY" : mail;
            account.Phone = phone.Equals("") ? "EMPTY" : phone;
            

            Global.db.Insertable(account).IgnoreColumns(x => new { x.Id, x.Registtime}).ExecuteCommand();
            return true;
        }

        public static bool UpdatePWD(string username, string password) {
            AccountMapper account = new AccountMapper();
            account.Username = username;
            account.Password = password;

            Global.db.Updateable(account).UpdateColumns(x => new { x.Password ,x.Username}).WhereColumns(x => new { x.Username }).ExecuteCommand();
            return true;
        }

        public static bool Login(string username, string password) {
            int count = Global.db.Queryable<AccountMapper>().Where(x => x.Username == username && x.Password == password).Count();

            if (count != 0) {
                return true;
            }

            return false;
        }

        public static string BasicInfo(string username)
        {
            return Global.db.Queryable<AccountMapper>().Where(x => x.Username == username).
                Select(x => new { x.Username, x.Registtime, x.Phone, x.Mail }).
                ToJson();
        }
    }
}
