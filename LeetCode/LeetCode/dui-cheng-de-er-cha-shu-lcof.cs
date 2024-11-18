namespace LeetCode;

public class dui_cheng_de_er_cha_shu_lcof
{
    public bool CheckSymmetricTree(TreeNode root) {
        if (root == null) {
            return true;
        }
        
        return CheckInternal(root.left, root.right);
    }
    
    private bool CheckInternal(TreeNode left, TreeNode right) {
        if (left == null && right == null) {
            return true;
        }
        
        if (left == null || right == null) {
            return false;
        }
        
        return left.val == right.val && CheckInternal(left.left, right.right) && CheckInternal(left.right, right.left);
    }
}