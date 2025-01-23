using System;

namespace LeetCode;

public class design_skiplist
{
    public class Skiplist {
    const int MAX_LEVEL = 32;
    const double P_FACTOR = 0.25;
    private SkiplistNode head;
    private int level;
    private Random random;

    public Skiplist() {
        this.head = new SkiplistNode(-1, MAX_LEVEL);
        this.level = 0;
        this.random = new Random();
    }
    
    public bool Search(int target) {
        SkiplistNode curr = this.head;
        for (int i = level - 1; i >= 0; i--) {
            while (curr.forward[i] != null && curr.forward[i].val < target) {
                curr = curr.forward[i];
            }
        }
        curr = curr.forward[0];
        if (curr != null && curr.val == target) {
            return true;
        } 
        return false;
    }
    
    public void Add(int num) {
        SkiplistNode[] update = new SkiplistNode[MAX_LEVEL];
        Array.Fill(update, head);
        SkiplistNode curr = this.head;
        for (int i = level - 1; i >= 0; i--) {
            while (curr.forward[i] != null && curr.forward[i].val < num) {
                curr = curr.forward[i];
            }
            update[i] = curr;
        }
        int lv = RandomLevel();
        level = Math.Max(level, lv);
        SkiplistNode newNode = new SkiplistNode(num, lv);
        for (int i = 0; i < lv; i++) {
            newNode.forward[i] = update[i].forward[i];
            update[i].forward[i] = newNode;
        }
    }
    
    public bool Erase(int num) {
        SkiplistNode[] update = new SkiplistNode[MAX_LEVEL];
        SkiplistNode curr = this.head;
        for (int i = level - 1; i >= 0; i--) {
            while (curr.forward[i] != null && curr.forward[i].val < num) {
                curr = curr.forward[i];
            }
            update[i] = curr;
        }
        curr = curr.forward[0];
        if (curr == null || curr.val != num) {
            return false;
        }
        for (int i = 0; i < level; i++) {
            if (update[i].forward[i] != curr) {
                break;
            }
            update[i].forward[i] = curr.forward[i];
        }
        while (level > 1 && head.forward[level - 1] == null) {
            level--;
        }
        return true;
    }

    private int RandomLevel() {
        int lv = 1;
        while (random.NextDouble() < P_FACTOR && lv < MAX_LEVEL) {
            lv++;
        }
        return lv;
    }
}

public class SkiplistNode {
    public int val;
    public SkiplistNode[] forward;

    public SkiplistNode(int val, int maxLevel) {
        this.val = val;
        this.forward = new SkiplistNode[maxLevel];
    }
}
}