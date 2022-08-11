namespace Threadnew
{
    internal class Program
    {
        class multithread
        {
            public static void thread1()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                    Thread t = Thread.CurrentThread;
                    Console.WriteLine(t.Name);

                }
            }
        }
        static void Main()
        {
            // Console.WriteLine("Hello, World!");
         /*   Thread mythread = Thread.CurrentThread;
            mythread.Name = "mainthread";
            Console.WriteLine(mythread.Name);*/
            Thread t1 = new Thread(new ThreadStart(multithread.thread1));
            t1.Name = "thread1";
            //t1.Start();
            Thread t2 = new Thread(new ThreadStart(multithread.thread1));
            //t2.Start();
            //t1.Join();
            t2.Name = "thread2";
            Thread t3 = new Thread(new ThreadStart(multithread.thread1));
            t3.Name = "thread3";
            t3.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Normal;
            t1.Priority = ThreadPriority.Lowest;
            t1.Start();
            t2.Start();
                t3.Start();

        }
    }
}