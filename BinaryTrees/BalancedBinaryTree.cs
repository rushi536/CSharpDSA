namespace BinaryTree
{
    
    public class BalancedBinaryTree : IProblem
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int value)
            {
                val=value;
            }
        }
        public void Run()
        {
            TreeNode root=new TreeNode(1);
            root.left=new TreeNode(2);
            root.right=new TreeNode(3);
            root.left.left=new TreeNode(4);
            root.left.right=new TreeNode(5);
        }
        public bool IsBalanced(TreeNode root)
        {
            return Height(root)!=-1;
        }
        public int Height(TreeNode node)
        {
            if (node==null) return 0;
            int left=Height(node.left);
            if (left == -1)
            {
                return -1;
            }
            int right =Height(node.right);
            if (right == -1)
            {
                return -1;
            }
            if(Math.Abs(left-right)>1)
            return -1;
            return 1+(Math.Max(left,right));
        }
    }
}