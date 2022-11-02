using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodePracticeConsole
{
    public class GroupAnagram
    {
        // group anagram 
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        //if its null or empty return an empty one
        if (strs == null || strs.Length == 0)
            return new List<IList<string>>();
        
        //create holder to return
        List<IList<string>> holder = new List<IList<string>>();
        //create dictionary using the current sorted string as key and a list of other similarly sorted string
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        //for each string in the array strs
        foreach (var str in strs)
        {
            //sort the current string and store it
            string current = new string(str.OrderBy(x => x).ToArray());
            
            //if the sorted string isnt already a key in the dictionary
            //aka if another word wasnt sorted to equal a key in the dictionary
            //then create a new dictionary input to check
            if (!dict.ContainsKey(current)){
                dict.Add(current, new List<string>());
            }
            //afterwards add the string to the list
            dict[current].Add(str);
        }
        
        //grab all created lists and return them
        foreach (var item in dict.Values)
            holder.Add(item);
        
        return holder;
    }

    }
}