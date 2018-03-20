using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading
{
    class TaskReturn
    {
        public void taskReturnType()
        {
            var a = Task<int>.Run(() =>
            {
                int max = 20000;
                int val = 0;
                for(val = 0; val <= max; val++)
                {
                    if(val == max/4 && DateTime.Now.Hour <= 10)
                    {
                        val++;
                        break;
                    }
                }
                return val;
            });
            Console.WriteLine("final value:" + a.Result);
        }
        static void Main(string[] args)
        {
            TaskReturn twr = new TaskReturn();
            twr.taskReturnType();
            Console.ReadKey();
        }
    }
}
