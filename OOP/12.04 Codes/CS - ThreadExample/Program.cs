using System;
using System.Threading;

namespace CS___ThreadExample
{
    class Worker1
    {
        public void loop1()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Worker1: " + Thread.CurrentThread.ManagedThreadId + "-> " + Thread.CurrentThread.Name + i);
            }
        }
    }
    class Worker2
    {
        public void loop2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Worker2: " + Thread.CurrentThread.ManagedThreadId + "-> " + Thread.CurrentThread.Name + i);
            }
        }
    }
    class Program
    {
        public static void run()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }
        static void Main(string[] args)
        {
            Worker1 w1 = new Worker1();
            Worker2 w2 = new Worker2();
            Thread t1 = new Thread(run);
            w1.loop1();
            w2.loop2();
            t1.Start();
            run();
            Console.Read();
        }
    }
}


/*
* Yeni CS projesi oluşturmak için gerekli kodlar
! - dotnet new console
! - dotnet restore
! - dotnet run
*/
