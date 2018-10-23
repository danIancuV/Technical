using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class Asyncarray
    {
        public int SumCalculation(int[] arr)
        {
            int totalsum = 0;

            Task<Int32> t1 = Task<Int32>.Factory.StartNew(() =>
            {
                int sum = 0;
                for (int k = 0; k <= arr.Length / 3 - 1; k++)
                {
                    sum += arr[k];  
                }
                Console.WriteLine("t1 associate thread is: {0}", Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
                return sum;
            });
            
            Task<Int32> t2 = Task<Int32>.Factory.StartNew(() =>
            {
                int sum = 0;
                for (int k = arr.Length / 3; k <= arr.Length / 3 * 2 - 1; k++)
                {
                    sum += arr[k];
                }
                Console.WriteLine("t2 associate thread is: {0}", Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10000);
                return sum;
            });

            Task<Int32> t3 = Task<Int32>.Factory.StartNew(() =>
            {
                int sum = 0;
                for (int k = arr.Length / 3 * 2; k <= arr.Length - 1; k++)
                {
                    sum += arr[k];
                }
                Console.WriteLine("t2 associate thread is: {0}", Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(5000);
                return sum;
            });

            //********wait one by one

            var tasklist = new List<Task<int>> {t1, t2, t3};
            while (tasklist.Count > 0)
            {
                Task<int>[] taskarray = tasklist.ToArray();
                int index = Task.WaitAny(taskarray);
                Console.WriteLine("Partial sum is {0}", tasklist[index].Result);
                totalsum += tasklist[index].Result;
                tasklist.RemoveAt(index);
            }
            return totalsum;

            //************wait all

            //Task<int>[] taskarray = tasklist.ToArray();
            //Task.WaitAll(taskarray);
            //foreach (var task in taskarray)
            //{
            //    Console.WriteLine("Partial sum is {0}", task.Result);
            //    totalsum += task.Result;
            //}

            //return totalsum;
        }
    }
}
