namespace ComputerScience.BigONotation
{
    /*
     * O(2N) denotes an algorithm whose growth doubles with each addition to the input data set.
     * The growth curve of an O(2N) function is exponential - starting off very shallow, then rising meteorically.
     * An example of an O(2N) function is the recursive calculation of Fibonacci numbers
     */
    public class O_2N
    {
        public static int Fibonacci(int number)
        {
            if (number <= 1) return number;

            return Fibonacci(number - 2) + Fibonacci(number - 1);
        }
    }
}