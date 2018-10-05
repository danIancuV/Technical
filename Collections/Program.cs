using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new filedbEntities();

            var evenNumbers = GetEvenNumbers();
            foreach (var i in evenNumbers) 
            {
                Console.WriteLine(i);
            }

            var months = GetMonths().ToList();
            foreach (var month in months)
            {
                Console.WriteLine(month);
            }

            var oddNumbers = GetOddNumbers();
            foreach (var i in oddNumbers)
            {
                Console.WriteLine(i);
            }
        }

        static IEnumerable<int> GetEvenNumbers()
        {
            for (var num = 2; num < 12; num++)
            {
                if (num % 2 == 0)
                    yield return num;
            }
        }

        static IEnumerable<string> GetMonths()
        {
            yield return "January";
            yield return "February";
            yield return "March";
        }

        static IList<int> GetOddNumbers()
        {
            var list = new List<int>();
            for (var i = 2 ; i < 12; i++)
            {
                if (i % 2 != 0)
                    list.Add(i);
            }
            return list;
        }
    }
}
