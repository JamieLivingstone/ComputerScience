namespace ComputerScience.BigONotation
{
    public class O_n
    {
        /*
        * Explanation: O(N) describes an algorithm whose performance will grow linearly and in direct proportion to the size of the input data set.
         * The example below also demonstrates how Big O favours the worst-case performance scenario;
         * a matching number could be found during any iteration of the for loop and the function would return early,
         * but Big O notation will always assume the upper limit where the algorithm will perform the maximum number of iterations. 
        */
        public static int? Example(int numberToFind)
        {
            var numbers = new[] {1, 2, 3, 4, 5};

            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numberToFind)
                {
                    return numbers[i];
                }
            }

            return null;
        }
    }
}