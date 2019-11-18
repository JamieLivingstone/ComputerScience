using System.Collections.Generic;

namespace ComputerScience.BigONotation
{
    /*
     * O(N2) represents an algorithm whose performance is directly proportional to the square of the size of the input data set.
     * This is common with algorithms that involve nested iterations over the data set.
     * Deeper nested iterations will result in O(N3), O(N4) etc.
     */
    public class O_N_Squared
    {
        public static bool ContainsDuplicates(int[] numbers)
        {
            for (var i = 0; i < numbers.Length; i++)
            {
                for (var j = 0; j < numbers.Length; j++)
                {
                    // Don't compare with self
                    if(i == j) continue;

                    if (numbers[i] == numbers[j])
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }
    }
}