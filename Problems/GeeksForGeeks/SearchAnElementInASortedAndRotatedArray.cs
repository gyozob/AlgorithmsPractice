namespace Problems.GeeksForGeeks
{
    public class SearchAnElementInASortedAndRotatedArray
    {
        [Test]
        [TestCase(new int[] { 5, 6, 7, 8, 9, 10, 1, 2, 3 }, 10)]
        [TestCase(new int[] { 2, 3, 5, 6, 7, 8, 9, 10, 1 }, 10)]
        [TestCase(new int[] { 2, 3, 5, 6, 7, 8, 9, 1 }, 9)]
        [TestCase(new int[] { 8, 9, 1, 2, 3, 5, 6, 7 }, 9)]
        [TestCase(new int[] { 1, 2, 3, 5, 6, 7, 8, 9, 10 }, 10)]
        public void Run(int[] input, int expectedPivot) 
        {
            var middle = input.Length / 2;
            var pivotIndex = -1;
            while (pivotIndex == -1) 
            {
                if (middle > input.Length - 1)
                {
                    middle = input.Length - 1;
                }

                if (middle < input.Length - 1 && input[middle] > input[middle + 1])
                {
                    pivotIndex = middle;
                    break;
                }
                if (middle > 0 && input[middle - 1] > input[middle])
                {
                    pivotIndex = middle - 1;
                    break;
                }

                if (input[0] > input[middle])
                {
                    middle = middle / 2;
                }
                else if (input[middle] > input[input.Length - 1])
                {
                    middle += middle / 2;
                }
                else 
                {
                    pivotIndex = input.Length - 1;
                }
            }

            Console.WriteLine($"Pivot element is {input[pivotIndex]} at index {pivotIndex}");
            Assert.That(input[pivotIndex], Is.EqualTo(expectedPivot));
        }
    }
}
