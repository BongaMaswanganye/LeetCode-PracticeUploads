using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodePracticeConsole
{
    public class ContainsDuplicate
    {

        public bool ContainsDuplicate(int[] nums) {
        //create empty hashset to store first instance of every number
        HashSet<int> Holder = new HashSet<int>();
        //loop through nums array
        foreach (int i in nums)
        {
            //hashset.add returns true if it adds the value and false if the value is present already
            //
            if (!Holder.Add(i))
            {
                //duplicate
                return true;
            }
        }
        return false;

    }
    }
}