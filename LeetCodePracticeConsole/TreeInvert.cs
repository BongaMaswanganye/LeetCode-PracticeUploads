using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodePracticeConsole
{
    public class TreeInvert
    {
        public TreeNode InvertTree(TreeNode root) {

         //recursion end case
         if (root == null){return root;}
         //temp value for holding right node
         TreeNode temp = root.right;
         //swap right with left
         root.right = root.left;
         //swap left with right
         root.left = temp;
         //do it again passing the left node
          InvertTree(root.left);
         //do it again using the right node
         InvertTree(root.right);
          //after it goes through the whole tree return the root
          return root;
        
        }
    }
}