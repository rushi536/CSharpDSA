using System.Xml;

namespace BinaryTree
{
    public class DiameterOfBinaryTree : IProblem
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
            TreeNode root=new TreeNode(1);
            root.left=new TreeNode(2);
            root.right=new TreeNode(3);
            root.left.left=new TreeNode(4);
            root.left.right=new TreeNode(5);

        }
        int diameter=0;
        public int Diameter(TreeNode root)
        {
            Height(root);
            return diameter;
        }
        public int Height(TreeNode node)
        {
            if(node==null) return 0;
            int leftHeight=Height(node.left);
            int rightHeight=Height(node.right);
            diameter=Math.Max(diameter,leftHeight+rightHeight);
            return 1+Math.Max(leftHeight,rightHeight);
        }
    }
}