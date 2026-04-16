namespace BinaryTree
{
    public class LevelOrderTraversal : IProblem
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int value)
            {
                val=value;
                left=null;
                right=null;
            }
        }
        public void Run()
        {
            TreeNode root= new TreeNode(1);
            root.left= new TreeNode(2);
            root.right=new TreeNode(3);
            root.left.left=new TreeNode(4);
            root.left.right=new TreeNode(5);
            var result= LevelOrder(root);
            Console.WriteLine("Level Order Traversal:");
            foreach (var level in result)
            {
                Console.WriteLine(string.Join(",", level));
            }
        }
        public List<List<int>> LevelOrder(TreeNode root)
        {
            List<List<int>> result= new List<List<int>>();
            if(root ==null) return result;
            Queue<TreeNode> queue=new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size=queue.Count;
                List<int> level=new List<int>();
                for(int i = 0; i < size; i++)
                {
                    TreeNode node=queue.Dequeue();
                    level.Add(node.val);
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                result.Add(level);
            }
            return result;
        }
    }
}