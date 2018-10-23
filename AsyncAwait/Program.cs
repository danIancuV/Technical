using System;
using System.Threading;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------*********USE PROCESSING IN BKG THREAD********-----------------

            Console.WriteLine($"Starting worker, {Thread.CurrentThread.ManagedThreadId}");

            var worker = new Worker();
            worker.DoWork();

            while (!worker.IsComplete)
            {
                Console.Write($".");
                Thread.Sleep(1000);
            }

            Console.WriteLine($"Done, {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(2000);

            //---------------*********WAIT ALL/////ONE-BY-ONE THREADS********----------------------------

            //var asyncarray = new Asyncarray();

            //int[] myarr = { 1, 2, 3, 4, 5, 6, 9, 10, 8 };
            //Console.WriteLine("Sum of array elements is:{0}", asyncarray.SumCalculation(myarr));
            //Console.WriteLine($"Done, {Thread.CurrentThread.ManagedThreadId}");

            //Thread.Sleep(2000);

            //-------------********WAIT ONE-BY-ONE REFACTORED*********---------------------

            //var asyncarrayrefactored = new Asyncarrayrefactored();

            //int[] myarr = { 1, 2, 3, 4, 5, 6, 9, 10, 8 };
            //Console.WriteLine("Sum of array elements is:{0}", asyncarrayrefactored.SumCalculation(myarr));
            //Console.WriteLine($"Done, {Thread.CurrentThread.ManagedThreadId}");

            //Thread.Sleep(2000);


            //---------------*********USE PROCESSING IN BKG THREAD----RE-MASTERED********-----------------

            //Console.WriteLine($"Starting syncasyncwork, {Thread.CurrentThread.ManagedThreadId}");

            //var syncasyncworker = new SyncAsyncWork();
            //syncasyncworker.DoSyncWork();
            //var rezult = syncasyncworker.DoAsyncWork();

            //while (!syncasyncworker.IsCompleted)
            //{
            //    Console.WriteLine($"Working....., { Thread.CurrentThread.ManagedThreadId}");
            //    Thread.Sleep(1000);
            //}

            //Console.WriteLine(rezult.Result);

            //Console.WriteLine($"EXIT, {Thread.CurrentThread.ManagedThreadId}");

            //---------------------------------------------------------


        }
    }
}
