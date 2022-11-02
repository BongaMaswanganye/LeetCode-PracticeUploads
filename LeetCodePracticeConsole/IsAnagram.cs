using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodePracticeConsole
{
    public class IsAnagram
    {
            public bool IsAnagram(string s, string t) {

        //create 2 holders for new arrays to sort 
        char[] sortedarray1 = s.ToCharArray();
        char[] sortedarray2 = t.ToCharArray();
        
        //array.sort O(nlog(n)) although normally faster in practice
        Array.Sort(sortedarray1);
        Array.Sort(sortedarray2);
        return sortedarray1.SequenceEqual(sortedarray2);
        


    }
    }
}