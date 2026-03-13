namespace BinarySearch
{
    public class InOrderTraversal : IProblem
    {
        public void Run()
        {
             TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.left.left = new TreeNode(4);
        root.left.right = new TreeNode(5);

        Console.WriteLine("Preorder:");
        BinaryTree binaryTree =new BinaryTree();
        binaryTree.PreOrder(root);

        // Console.WriteLine("\nInorder:");
        // Inorder(root);

        // Console.WriteLine("\nPostorder:");
        // Postorder(root);
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int Value)
        {
            val=Value;
            left=null;
            right=null;
        }
    }
    public class BinaryTree
    {
        public void PreOrder(TreeNode root)
        {
            if(root==null)
            return;
            Console.Write(root.val+" ");
            PreOrder(root.left);
            PreOrder(root.right);
        }

        public void Inorder(TreeNode root)
        {
            if(root==null)
            return;
           
            Inorder(root.left);
            Console.Write(root.val+" ");
            Inorder(root.right);
        }
        public void Postorder(TreeNode root)
        {
            if(root==null)
            return;
           
            Postorder(root.left);
            Postorder(root.right);
             Console.Write(root.val+" ");
        }
    }
}