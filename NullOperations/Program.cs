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

            // ===== Task 3: If–Else Age Check =====
            Console.WriteLine("=== Task 3: If–Else Age Check ===");
            AgeChecker ageChecker = new AgeChecker();
            ageChecker.CheckAgeCategory();

            Console.WriteLine("\nAll tasks executed successfully!");
            // Task4
            Console.WriteLine("=== Task 4: Switch Case (Day of the Week) ===");
            DayChecker dayChecker = new DayChecker();
            dayChecker.ShowDayOfWeek();
            Console.WriteLine("\nTask 4 completed successfully!");
        }
    }
}
