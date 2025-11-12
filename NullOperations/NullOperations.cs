using System;

namespace NullOperationsApp
{
    internal class NullOperations
    {
        public void PerformNullChecks()
        {

            string username = null;


            string message = (username == null)
                ? "Username is not available"
                : username;
            Console.WriteLine("Ternary Operator result: " + message);


            Console.WriteLine("Null-Coalescing Operator result: " + (username ?? "Username is not available"));


            username ??= "DefaultUser";
            Console.WriteLine("Updated username after ??=: " + username);
        }
    }
}