﻿
    using System;
    using System.Threading;

    namespace MultithreadingApplication
    {
        class MainThreadProgram
        {
            static void Main(string[] args)
            {
                Thread th = Thread.CurrentThread;
                th.Name = "MainThread";

                Console.WriteLine("This is {0}", th.Name);
                Console.ReadKey();
            }
        }
    }
