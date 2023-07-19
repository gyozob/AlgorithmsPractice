namespace Problems.GeeksForGeeks
{
    /// <summary>
    /// Link to the problem https://www.geeksforgeeks.org/find-a-peak-in-a-given-array/
    /// </summary>
    public class FindAPeakElementWhichIsNotSmallerThanItsNeighbours
    {
        [Test]
        public void Run() 
        {
            var input = new[] { 10, 20, 15, 2, 23, 90, 67 };
            for (int i = 1; i < input.Length - 1; i++)
            {
                var isCurrentGreaterThanNext = input[i] > input[i + 1];
                if (input[i] > input[i - 1] && isCurrentGreaterThanNext)
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
