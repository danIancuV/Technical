using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class SyncAsyncWork
    {
        public bool IsCompleted { get; private set; }

        public void DoSyncWork()
        {
            Console.WriteLine($"Doing some sync work, {Thread.CurrentThread.ManagedThreadId}");
        }

        public async Task<string> DoAsyncWork()
        {
            IsCompleted = false;
            Console.WriteLine($"Async task is starting, {Thread.CurrentThread.ManagedThreadId}");           
            await Operation();
            IsCompleted = true;
            return Operation().Result;
        }

        public Task<string> Operation()
        {
            return Task.Factory.StartNew(() =>
            {
                Console.WriteLine($"executing task, {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(3000);
                return $"work done";               
            });

        }
    }
}
