// Beginner's Guide
// 226. Invert Binary Tree
public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
        {
            return null;
        }
        (root.left, root.right) = (InvertTree(root.right), InvertTree(root.left));
        return root;
    }
}