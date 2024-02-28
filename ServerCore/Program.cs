﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace ServerCore
{
    internal class Program
    {
        static void MainThread(object state)
        {
            for(int i=0;i<5;i++)
                Console.WriteLine("Hello Thread!");
        }

        static void Main(string[] args)
        {
            ThreadPool.SetMinThreads(1, 1); // 최소
            ThreadPool.SetMaxThreads(5, 5); // 최대

            for(int i=0;i<5;i++)
            {
                Task t = new Task(() => { while (true) { } });
                t.Start();
            }

            //for(int i=0;i<5;i++)
            //    ThreadPool.QueueUserWorkItem((obj) => { while (true) { } });

            ThreadPool.QueueUserWorkItem(MainThread);

            //Thread t = new Thread(MainThread);
            //t.Name = "Test Thread";
            //t.IsBackground = true;
            //t.Start();
            //Console.WriteLine("Waiting for Thread World!");

            //t.Join();
            //Console.WriteLine("Hello, World!");
            while(true)
            {

            }
        }
    }
}