using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ConstructStringfromBinaryTree
    {
        public string Tree2str(TreeNode t)
        {
            if (null == t)
            {
                return string.Empty;
            }
            StringBuilder useStringBuilder = new StringBuilder();
            useStringBuilder.Append(t.val);
            if (!(null == t.left && null == t.right))
            {
                useStringBuilder.Append(Tree2strLoop(t.left));
                if (null != t.right)
                {
                    useStringBuilder.Append(Tree2strLoop(t.right));
                }
            }
           

            return useStringBuilder.ToString();

        }

        private string Tree2strLoop(TreeNode t)
        {
            StringBuilder useStringBuilder = new StringBuilder();
     
            useStringBuilder.Append("(");
            if (null != t)
            {
                useStringBuilder.Append(t.val.ToString());

                if ( !(null == t.left && null == t.right) )
                {
                    useStringBuilder.Append(Tree2strLoop(t.left));
                    if (null != t.right)
                    {
                        useStringBuilder.Append(Tree2strLoop(t.right));
                    }
                }
            
            }

            useStringBuilder.Append(")");

            return useStringBuilder.ToString();
        }
    }
}
