using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    class ThreadA
    {
        public void ThreadName()
        {
            Thread th = Thread.CurrentThread;
             
            Console.WriteLine(th.Name + " is running");
        }
        public void Thread1()
        {
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void Thread2()
        {
            for (int i = 10; i < 6; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class ThreadEx 
    {
        static void Main(string[] args)
        {
            ThreadA obj1 = new ThreadA();
            Thread t1 = new Thread(new ThreadStart(obj1.ThreadName));      
             
            Thread t2 = new Thread(new ThreadStart(obj1.Thread1));
            Thread t3 = new Thread(new ThreadStart(obj1.Thread2));
            Thread t4 = new Thread(new ThreadStart(obj1.ThreadName));
            Thread t5 = new Thread(new ThreadStart(obj1.ThreadName));

            t1.Name = "thread1";
            t4.Name = "thread4";
            t5.Name = "thread5";

            t1.Priority = ThreadPriority.Lowest;
            t4.Priority = ThreadPriority.Normal;
            t5.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            Console.ReadKey();
        }
    }
}
