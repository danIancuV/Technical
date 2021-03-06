﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Worker
    {
        public bool IsComplete { get; private set; }

        public async Task DoWork()
        {
            IsComplete = false;
            Console.WriteLine($"Doing work, {Thread.CurrentThread.ManagedThreadId}");

            await LongOperation();

            Console.WriteLine($"Work completed, {Thread.CurrentThread.ManagedThreadId}");

            IsComplete = true;
        }

        private Task LongOperation()
        {
            return Task.Factory.StartNew(() =>
            {
                Console.WriteLine($"Working, {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(4000);
            });
        }


    }
}
