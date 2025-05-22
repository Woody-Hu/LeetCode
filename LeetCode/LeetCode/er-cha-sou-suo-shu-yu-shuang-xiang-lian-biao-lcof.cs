namespace LeetCode;

public class er_cha_sou_suo_shu_yu_shuang_xiang_lian_biao_lcof
{
    public class Node {
        public int val;
        public Node left;
        public Node right;

        public Node() {}

        public Node(int _val) {
            val = _val;
            left = null;
            right = null;
        }

        public Node(int _val,Node _left,Node _right) {
            val = _val;
            left = _left;
            right = _right;
        }
    }

    private Node _pre;
    
    private Node _head;
    
    public Node TreeToDoublyList(Node root) {
        if(root == null) return null;
        DFS(root);
        _head.left = _pre;
        _pre.right = _head;
        return _head;
    }
    
    private void DFS(Node cur) {
        if(cur == null) return;
        DFS(cur.left);
        if(_pre != null) _pre.right = cur;
        else _head = cur;
        cur.left = _pre;
        _pre = cur;
        DFS(cur.right);
    }
}