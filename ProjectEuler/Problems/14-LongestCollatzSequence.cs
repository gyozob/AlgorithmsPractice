namespace Problems
{
    /// <summary>
    /// Link to the problem https://projecteuler.net/problem=14
    /// </summary>
    public class LongestCollatzSequence
    {
        [Test]
        public void Run()
        {
            int maxStartingNumber = 1000000;
            int startingNumber = 0;
            int longestChain = -1;
            for (int i = maxStartingNumber; i > 1; i--)
            {
                var currentN = i;
                var currentChainLength = 0;
                while (currentN > 1)
                {
                    if (currentN % 2 == 0)
                    {
                        currentN = currentN / 2;
                    }
                    else
                    {
                        currentN = 3 * currentN + 1;
                    }

                    currentChainLength++;
                }

                if (currentChainLength > longestChain)
                {
                    longestChain = currentChainLength;
                    startingNumber = i;
                }
            }

            Console.WriteLine($"Longest chain under {maxStartingNumber} starts from {startingNumber} and it has {longestChain} chains.");
        }
    }
}