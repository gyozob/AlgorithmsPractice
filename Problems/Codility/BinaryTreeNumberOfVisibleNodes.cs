namespace Problems.Codility
{
    public class BinaryTreeNumberOfVisibleNodes
    {
        [Test]
        [TestCaseSource(nameof(TestData))]
        public void Run((Tree root, int expectedVisibleNodes) input) 
        {
            var numberOfVisibleNodes = GetNumberOfVisibleNodes(input.root, input.root.X) + 1; // + 1 because root is always visible
            Assert.That(input.expectedVisibleNodes, Is.EqualTo(numberOfVisibleNodes));
        }

        private int GetNumberOfVisibleNodes(Tree node, int lastGreatest)
        {
            var numberOfVisibleNodes = 0;

            if (lastGreatest < node.X)
            {
                lastGreatest = node.X;
                numberOfVisibleNodes++;
            }

            if (node.Left != null)
            {
                numberOfVisibleNodes += GetNumberOfVisibleNodes(node.Left, lastGreatest);
            }

            if (node.Right != null)
            {
                numberOfVisibleNodes += GetNumberOfVisibleNodes(node.Right, lastGreatest);
            }

            return numberOfVisibleNodes;
        }

        private static IEnumerable<(Tree root, int expectedVisibleNodes)> TestData()
        {
            //              5
            //            /   \
            //           4     6
            //          /     /
            //        6      4
            //       /
            //      7
            var root = new Tree(5);
            root.Left = new Tree(4);
            root.Right = new Tree(6);
            root.Right.Left = new Tree(5);
            root.Left.Left = new Tree(6);
            root.Left.Left.Left = new Tree(7);
            return new List<(Tree root, int expectedVisibleNodes)>() { (root, 4) };
        }
    }

    public class Tree 
    {
        public Tree(int value)
        {
            X = value;
        }
        public int X { get; set; }
        public Tree Left { get; set; }
        public Tree Right { get; set; }
    }
}
