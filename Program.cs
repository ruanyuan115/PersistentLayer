using System;
using PersistentLayer.Mapper.Account;
using PersistentLayer.Apis;
using System.Threading.Tasks;
using System.Threading;

namespace PersistentLayer
{

    class Worker
    {
        /*private  Task<int> LOOP(string str)
        {
            return 
            
        }*/
        public async  Task PrintA()
        {
            string str = "1234";
            await Task<int>.Run(() => {
                Thread.Sleep(2000);
                Console.WriteLine(str);
                return 1;
            }); ;

            Console.WriteLine("A");
        }

        public async  Task PrintB()
        {

            Console.WriteLine("B");
        }
    }
    class Program
    {
        
        
        static async Task Main(string[] args)


        {
            //var lista = Global.db.Queryable<AccountMapper>().ToJson();
            //Console.WriteLine(lista);
            //int b = 1;

            //AccountApi.Register("TEST2", "1234");




            //Task.WaitAll(task, task2);




            //AccountApi.UpdatePWD("TEST", "12345567");

            Console.WriteLine(AccountApi.BasicInfo("TEST2"));


            Console.ReadKey();




            

        }
    }
}
