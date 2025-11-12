using System;

namespace NullOperationsApp
{
    internal class LoopTasks
    {
        public void RunLoops()
        {
            // --- For Loop: Sum from 1 to N ---
            Console.Write("Enter a number N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum from 1 to {N} = {sum}");

            // --- While Loop: Numbers 1–20 (skip multiples of 4, stop at 15) ---
            Console.WriteLine("\nNumbers 1–20 (skip multiples of 4, stop at 15):");
            int num = 1;
            while (num <= 20)
            {
                if (num == 15)
                    break;
                if (num % 4 == 0)
                {
                    num++;
                    continue;
                }
                Console.Write($"{num} ");
                num++;
            }

            // --- Foreach Loop: Sum of array elements ---
            Console.WriteLine("\n\nSum of elements in array:");
            int[] arr = { 2, 4, 6, 8, 10 };
            int arrSum = 0;
            foreach (int x in arr)
            {
                arrSum += x;
            }
            Console.WriteLine($"Sum = {arrSum}");
        }
    }
}