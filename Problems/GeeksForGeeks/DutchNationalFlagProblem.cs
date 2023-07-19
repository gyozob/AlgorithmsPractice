namespace Problems.GeeksForGeeks
{
    /// <summary>
    /// Sort an array of 0s, 1s and 2s or "Dutch National Flag problem"
    /// Link to the problem https://www.geeksforgeeks.org/sort-an-array-of-0s-1s-and-2s/
    /// </summary>
    public class DutchNationalFlagProblem
    {
        [Test]
        public void Run() 
        {
            var input = new[] { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };
            var output = new int[input.Length];
            var countOf0 = 0;
            var countOf1 = 0;
            var countOf2 = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 0)
                {
                    countOf0++;
                }

                if (input[i] == 1)
                {
                    countOf1++;
                }

                if (input[i] == 2)
                {
                    countOf2++;
                }
            }

            for (int i = 0; i < countOf0; i++)
            {
                output[i] = 0;
            }

            for (int i = countOf0; i < countOf0 + countOf1; i++)
            {
                output[i] = 1;
            }

            for (int i = countOf0 + countOf1; i < countOf0 + countOf1 + countOf2; i++)
            {
                output[i] = 2;
            }

            var outputString = string.Join(", ", output);
            Console.WriteLine(outputString);
            Assert.That(outputString, Is.EqualTo("0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2"));
        }
    }
}
