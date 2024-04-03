// CPRG-211-F
// Lab 10 Recursion 
// 000694773 Nara Park 

namespace LabRecursion
{
    class Program
    {
        // Calculates the sum of all numbers from n to m recursively

        public static int RecursiveSum (int n ,int m)
        {
            if (n == m)
            {
                return n; // Base case
            }
            else // Recursive case: return current number and sum of rest
            {
                return n + RecursiveSum(n + 1, m);
            }
        }

        // Counts how many times a number can be evenly divided by 2
        public static int RecursiveDivision(int a)
        {
            if (a % 2 != 0 || a == 0)
            {
                return 0; // Base case
            }
            else  // Recursive case: divide the number by 2 and count this division
            {
                return 1 + RecursiveDivision(a / 2);
            }
        }


        static void Main(string[] args)
        {
            // Addition part
            Console.WriteLine("Addition");
            Console.WriteLine("Enter number n:");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter number m:");
            int m = Int32.Parse(Console.ReadLine());
            int result = RecursiveSum(n, m);
            Console.WriteLine(result);

            // Division part 
            Console.WriteLine("Division");
            Console.WriteLine("Enter your number:");
            int a = Int32.Parse(Console.ReadLine());
            int result2 = RecursiveDivision(a);
            Console.WriteLine($"Total number of division : {result2}");
        }
    }
}
