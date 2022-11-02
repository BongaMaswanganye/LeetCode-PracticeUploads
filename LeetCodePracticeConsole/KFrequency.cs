using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodePracticeConsole
{
    public class KFrequency
    {
        //top k frequency 
 public int[] TopKFrequent(int[] nums, int k) {
        //if empty or null do nothing
         if (nums == null || nums.Length == 0 || k == 0)
            return new int[] { };
        
        //create dictionary holding each number and how many times it occurs
        Dictionary<int,int> holder = new Dictionary<int,int>();
        //iterate over array to populate dictionary
        foreach (int number in nums)
        {
            if (!holder.ContainsKey(number))
            {
                holder.Add(number, 0);
            }
            holder[number] += 1;
        }
        //sort dictionary by value, grab k amount of keys, parse it to a list of ints then to an array of ints
        
        return holder.OrderByDescending(x => x.value).Select(x => x.key).Take(k).ToList<int>().ToArray();

    }


    }
}