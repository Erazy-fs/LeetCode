// Beginner's Guide
// 2236. Root Equals Sum of Children
public class Solution
{
    public bool CheckTree(TreeNode root) => root.val == root.left.val + root.right.val ? true : false;
}