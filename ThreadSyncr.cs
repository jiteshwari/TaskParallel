using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    class ThreadSyncr 
    {
        public void Thread1()
        {
            lock (this)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void Thread2()
        {
            lock (this)
            {
                for (int i = 4; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            ThreadSyncr obj1 = new ThreadSyncr();
            Thread t1 = new Thread(new ThreadStart(obj1.Thread1));
            Thread t2 = new Thread(new ThreadStart(obj1.Thread2));
           
            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();

            Console.ReadKey();
        }
    }
}
