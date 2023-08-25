namespace Problems.Codility
{
    public class MaximumSquaredDistance
    {
        [Test]
        [TestCase(1, 1, 2, 3, 5)]
        [TestCase(2, 4, 2, 4, 8)]
        public void Run(int a, int b, int c, int d, int expectedMaxSquare)
        {
            var possiblePoints = GetPossiblePoints(a, b, c, d);

            double maxSquare = 0;
            for (int i = 0; i < possiblePoints.Length; i++)
            {
                var x2 = possiblePoints[i][2];
                var y1 = possiblePoints[i][1];
                var currentSquare = y1 + x2;
                if (currentSquare > maxSquare)
                {
                    maxSquare = currentSquare;
                }
            }

            Assert.That(maxSquare, Is.EqualTo(expectedMaxSquare));
        }

        private int[][] GetPossiblePoints(int a, int b, int c, int d)
        {
            var possible = new int[] { a, b, c, d };
            var result = new List<int[]>() { };

            void swap(int i, int j)
            {
                var tmp = possible[i];
                possible[i] = possible[j];
                possible[j] = tmp;
            }

            void permutation(int i) 
            {
                if (i == possible.Length) 
                {
                    var newPermutation = (int[])possible.Clone();
                    result.Add(newPermutation);
                }
                else
                {
                    for (var j = i; j < possible.Length; j++)
                    {
                        swap(i, j);
                        permutation(i + 1);
                        swap(i, j);
                    }
                }
            }

            permutation(0);

            return result.ToArray();
        }
    }
}
