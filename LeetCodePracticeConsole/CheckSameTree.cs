using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodePracticeConsole
{
    public class CheckSameTree{
        public bool IsSameTree(TreeNode p, TreeNode q) {
        //the trees are not the same if:
        //one is null and the other isn't
        //if there values aren't the same
        //so we can check for that then return false
            if ((p != null && q == null) || (p == null && q != null) || (p != null && q != null && p.val != q.val))
                {return false;}
        //if it passes the above conditions, check if we reached the end. 
        //if we did return true
        //otherwise do another recursive loop
            else
                {return p == null && q == null ? true : IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);}
        }
    }
}