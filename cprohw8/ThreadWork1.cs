using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cprohw8
{
    public static class ThreadWork1
    {
        public static void Start()
        {
            for (int i = 0; i < 2; i++) {
                Thread newThread = new Thread(() =>
                {
                    for (int j = 0;j < 10; j++) { 
                        Console.WriteLine("[{0}]: id:{1} ", Thread.CurrentThread.Name, Thread.CurrentThread.ManagedThreadId);
                        Thread.Sleep(500);
                    }
                });
                newThread.Name = $"Thread <{i}>";
                newThread.Start();
            }
        }
    }
}
