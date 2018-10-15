using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Starting worker, {Thread.CurrentThread.ManagedThreadId}");

            var worker = new Worker();
            worker.DoWork();

            while (!worker.IsComplete)
            {
                Console.Write($"., {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Done");
            Console.ReadKey();

            Console.WriteLine($"Starting syncasyncwork, {Thread.CurrentThread.ManagedThreadId}");

            var syncasyncworker = new SyncAsyncWork();
            syncasyncworker.DoSyncWork();           
           
            var rezult = syncasyncworker.DoAsyncWork();

       
            Console.WriteLine(rezult.Result);
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}");
            
           
        }
    }
}
