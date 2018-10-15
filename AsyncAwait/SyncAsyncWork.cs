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
        
        public void DoSyncWork()
        {
            Console.WriteLine($"Doing some sync work, {Thread.CurrentThread.ManagedThreadId}");
        }

        public async Task<string> DoAsyncWork()
        {
            Console.WriteLine($"Async task is starting, {Thread.CurrentThread.ManagedThreadId}");

            string result = await Operation();
            return result;
        }

        public Task<string> Operation()
        {
            Thread.Sleep(4000);
            return Task.Factory.StartNew(() => $"work done, {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
