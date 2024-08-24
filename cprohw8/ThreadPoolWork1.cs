using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cprohw8
{
    public static class ThreadPoolWork1
    {    
        public static void Start()
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(DoWork, $"Task {i}");
            }
        }

        static void DoWork(object? taskName)
        {
            Console.WriteLine($"[{taskName}] : id:  {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
