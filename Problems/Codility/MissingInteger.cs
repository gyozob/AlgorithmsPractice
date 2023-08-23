namespace Problems.Codility
{
    /// <summary>
    /// Find the lowest positive integer greater than 0 which doesn't exists in array A with max 100000 elements
    /// </summary>
    public class MissingInteger
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { -1, -2, 6, 5 })]
        [TestCase(new int[] { -1, -2 })]
        public void Run(int[] a)
        {
            var dictA = a.ToHashSet();
            var minPositive = 0;
            for (int i = 1; i <= 100001; i++)
            {
                if (!dictA.Contains(i))
                {
                    minPositive = i;
                    break;
                }
            }

            Assert.Greater(minPositive, 0);
        }
    }
}
