namespace Problems.GeeksForGeeks
{
    /// <summary>
    /// Link to the problem https://www.geeksforgeeks.org/find-a-peak-in-a-given-array/
    /// </summary>
    public class FindAPeakElementWhichIsNotSmallerThanItsNeighbours
    {
        [Test]
        [TestCase(new int[] { 10, 20, 15, 2, 23, 90, 67 })]
        [TestCase(new int[] { 30, 20, 15, 2, 23, 90, 67 })]
        [TestCase(new int[] { 30, 20, 15, 2, 23, 90, 100 })]
        [TestCase(new int[] { 10, 10, 10 })]
        public void Run(int[] input) 
        {
            for (int i = 0; i < input.Length; i++)
            {
                var isCurrentGreaterThanNext = i < input.Length -1 && input[i] > input[i + 1];
                if (i == 0 || (input[i] >= input[i - 1]) && (i == input.Length - 1 || input[i] >= input[i + 1]))
                {
                    Console.WriteLine(input[i]);
                    continue;
                }

                // if so then the check in the next iteration doesn't make sense so we step over
                if (isCurrentGreaterThanNext)
                {
                    i++;
                }
            }
        }
    }
}
