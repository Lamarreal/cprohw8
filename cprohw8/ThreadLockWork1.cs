using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cprohw8
{
    public class ThreadLockWork1
    {
        static object locker = new object();
        static int sharedObject = 0;
        public static void Start()
        {
            

            for (int i = 0; i < 2; i++)
            {
                Thread newThread = new Thread(() =>
                {
                    lock (locker)
                    {
                        sharedObject += 1000;
                    }
                });
               
                newThread.Start();
            }

            Console.WriteLine(sharedObject);
        }
    }
}
