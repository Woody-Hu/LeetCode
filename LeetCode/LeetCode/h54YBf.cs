using System.Collections.Generic;
using System.Linq;

namespace LeetCode;

public class h54YBf
{
    public class Codec {
        public string serialize(TreeNode root) {
            return rserialize(root, "");
        }

        public TreeNode deserialize(string data) {
            string[] dataArray = data.Split(",");
            LinkedList<string> dataList = new LinkedList<string>(dataArray.ToList());
            return rdeserialize(dataList);
        }

        public string rserialize(TreeNode root, string str) {
            if (root == null) {
                str += "None,";
            } else {
                str += root.val.ToString() + ",";
                str = rserialize(root.left, str);
                str = rserialize(root.right, str);
            }
            return str;
        }
  
        public TreeNode rdeserialize(LinkedList<string> dataList) {
            if (dataList.First.Value.Equals("None")) {
                dataList.RemoveFirst();
                return null;
            }
  
            TreeNode root = new TreeNode(int.Parse(dataList.First.Value));
            dataList.RemoveFirst();
            root.left = rdeserialize(dataList);
            root.right = rdeserialize(dataList);
    
            return root;
        }
    }
}