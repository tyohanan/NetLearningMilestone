using System;
using System.Collections.Generic;

namespace NetLearningMilestone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fibonaccy = new List<int>() { 1, 1 };

            while (fibonaccy[fibonaccy.Count - 1] != 6765)
            {
                var previous = fibonaccy[fibonaccy.Count - 1];
                var previous2 = fibonaccy[fibonaccy.Count - 2];

                fibonaccy.Add(previous + previous2);
            }


            foreach (int item in fibonaccy)
            {
                Console.WriteLine(item);
            }
        }
    }

}
