using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class Asyncarrayrefactored
    {
        public int SumCalculation(int[] arr)
        {
            int totalsum = 0;

            int[] arr1 = arr.Skip(0).Take(3).ToArray();
            int[] arr2 = arr.Skip(3).Take(3).ToArray();
            int[] arr3 = arr.Skip(6).Take(3).ToArray();

            List<int[]> arrlist = new List<int[]> {arr1, arr2, arr3};

            foreach (var subarr in arrlist)
            {
                Task<Int32> t = Task<int>.Factory.StartNew(() =>
                {
                    Thread.Sleep(2000);
                    return PartialSumCalculation(subarr);                   
                });                   
                
                Console.WriteLine("Partial sum is {0}", t.Result);
                totalsum += t.Result;   
            }

            return totalsum;
        }

        private static int PartialSumCalculation(int[] arr)
        {
            int sum = 0;
            for (int k = 0; k <= arr.Length - 1; k++)
            {
                sum += arr[k];
            }
            Console.Write("associated thread is: {0} ---- ", Thread.CurrentThread.ManagedThreadId);           
            return sum;
        }
    }
}