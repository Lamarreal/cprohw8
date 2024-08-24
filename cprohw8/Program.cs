using cprohw8;

ThreadWork1.Start();
Thread.Sleep(6000);

ThreadPoolWork1.Start();
Thread.Sleep(1000);

ThreadLockWork1.Start();
Thread.Sleep(1000);

ThreadSemaphoreWork1.Start();