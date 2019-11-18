namespace ComputerScience.BigONotation
{
    /*
     * Logarithms are slightly trickier to explain so I'll use a common example:
     * Binary search is a technique used to search sorted data sets. It works by selecting the middle element of the data set,
     * essentially the median, and compares it against a target value. If the values match it will return success.
     * If the target value is higher than the value of the probe element it will take the upper half of the data set and perform
     * the same operation against it. Likewise, if the target value is lower than the value of the probe element it will perform
     * the operation against the lower half. It will continue to halve the data set with each iteration until the value has been found
     * or until it can no longer split the data set.
     * This type of algorithm is described as O(log N). The iterative halving of data sets described in the binary search example produces a growth curve that peaks at the beginning and slowly flattens out as the size of the data sets increase e.g. an input data set containing 10 items takes one second to complete, a data set containing 100 items takes two seconds, and a data set containing 1000 items will take three seconds. Doubling the size of the input data set has little effect on its growth as after a single iteration of the algorithm the data set will be halved and therefore on a par with an input data set half the size. This makes algorithms like binary search extremely efficient when dealing with large data sets.
     */
    public class O_log_N
    {
        
    }
}