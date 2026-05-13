using System;

namespace BasicCSharpPractise
{
    public class RefParameter
    {
        public void AddFive(ref int number)
        {
            number += 5;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            int x = 10;

            RefParameter rp = new RefParameter(); // Create object
            rp.AddFive(ref x);                    // Call method

            Console.WriteLine(x); // Output: 15
        }
    }
}
