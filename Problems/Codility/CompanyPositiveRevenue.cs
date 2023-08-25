namespace Problems.Codility
{
    /// <summary>
    /// Array represents company transactions ordered by date
    /// Positive numbers represents incomes, negatives represents payments
    /// Move required payments to the end in order to always keep the company's revenue positive
    /// What is the minimum number of moves for this?
    /// </summary>
    public class CompanyPositiveRevenue
    {
        [Test]
        [TestCase(new int[] { 10, -10, -1, -1, 10 }, 1)] // TODO: update algoritm for the calculation of the minimum - for this case 1 is the minimum but the current implementation does it in 2 moves
        [TestCase(new int[] { -1, -1, -1, 1, 1, 1, 1 }, 3)]
        [TestCase(new int[] { 5, -2, -3, 1 }, 0)]
        public void Run(int[] a, int expectedNumberOfMoves) 
        {
            var numberOfMoves = 0;
            var finalSum = 0;
            for (int i = 0; i < a.Length; i++) 
            {
                var currentSum = finalSum;
                currentSum += a[i];
                if (currentSum < 0)
                {
                    numberOfMoves++;
                }
                else 
                {
                    finalSum = currentSum;
                }
            }

            Assert.That(numberOfMoves, Is.EqualTo(expectedNumberOfMoves));
        }
    }
}
