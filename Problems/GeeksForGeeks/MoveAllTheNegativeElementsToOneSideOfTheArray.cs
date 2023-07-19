using System.Linq;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace Problems.GeeksForGeeks
{
    /// <summary>
    /// Link to the problem https://www.geeksforgeeks.org/move-negative-numbers-beginning-positive-end-constant-extra-space/
    /// </summary>
    public class MoveAllTheNegativeElementsToOneSideOfTheArray
    {
        [Test]
        public void Run() 
        {
            var input = new[] { -12, 11, -13, -5, 6, -7, 5, -3, -6 };
            var lastNegativeItemIndex = -1;
            for (int i = 0; i < input.Length; i++) 
            {
                if (input[i] > 0) 
                {
                    continue;
                }

                lastNegativeItemIndex++;
                if (lastNegativeItemIndex == i)
                {
                    continue;
                }

                var tmp = input[i];
                input[i] = input[lastNegativeItemIndex];
                input[lastNegativeItemIndex] = tmp;
            }

            var outputString = string.Join(", ", input);
            Console.WriteLine(outputString);
            Assert.That(outputString, Is.EqualTo("-12, -13, -5, -7, -3, -6, 5, 6, 11"));
        }
    }
}
