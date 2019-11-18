using System;

namespace ComputerScience.BigONotation
{
    public class O_1
    {
        /*
         * Explanation: O(1) describes an algorithm that will always execute in the same time (or space)
         * regardless of the size of the input data set (constant time).
         */
        public static void Example()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };

            var number = numbers[1]; // 0(1)
            
            Console.WriteLine(number);
        }
    }
}