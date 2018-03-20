using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    /// <summary>
    /// class to show two method working parallely
    /// MultiThreading.TaskParallel
    /// </summary>
    class TaskParallel
    {
        
        public static void printMessage()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Hello JS");
           
        }
        public static void threadName()
        {
            Thread obj1 = Thread.CurrentThread;
            obj1.Name = "main thread";
            Console.WriteLine("thread name is : " + obj1.Name);
        }
        static void Main(string[] args)
        { 

            Task task1 = new Task(() => printMessage());    //lambda with named method
            Task task2 = new Task(() => threadName());
            task1.Start();
            task2.Start();
            Console.ReadKey();
        }
    }
}
