using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cprohw8
{
    public class ThreadSemaphoreWork1
    {
        private static Semaphore _semaphore = new Semaphore(2,2);
        static int shared = 0;
        public static void Start()
        {
            for (int i = 1; i <= 5; i++)
            {
             
                Thread NewThread = new Thread(() => AccessResource(i));

                NewThread.Start();
                Thread.Sleep(100);
            }
        }

        static void AccessResource(int taskNumber)
        {
            int Id = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"[Task {taskNumber}] is waiting...");
            _semaphore.WaitOne();

            Console.WriteLine($"[Task {taskNumber}] has entered.");           
            Thread.Sleep(1000);
            shared++;
            Console.WriteLine($"[Task {taskNumber}] is leaving. now number is: {shared}");      
            
            _semaphore.Release();
        }
    }
}
