using System;

namespace NullOperationsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ===== Task 2: Null Operations =====
            Console.WriteLine("=== Task 2: Null Operations ===");
            NullOperations nullOps = new NullOperations();
            nullOps.PerformNullChecks();

            Console.WriteLine("\nTask 2 completed successfully!\n");
        }
    }
}