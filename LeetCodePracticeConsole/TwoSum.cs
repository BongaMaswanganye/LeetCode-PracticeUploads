using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodePracticeConsole
{
    //to execute this file,in the terminal run:
    //>dotnet build LeetCodePracticeConsole.csproj -p:StartupObject=LeetCodePracticeConsole.PivotNumber
    //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

    //You may assume that each input would have exactly one solution, and you may not use the same element twice.

    //You can return the answer in any order.
    public class TwoSum
    {
        //decent attempt for a initial run, i want to make it faster, might come back to it later
         public int[] TwoSumAttempt1(int[] nums, int target) {
        //go through for first value
        for (int x = 0; x < nums.Length;x++){
            //this gives me the number i need to add to the current index

            //search for second value 
            for (int y = 0; y < nums.Length; y++){
                //cant use the same number so skip it
                if (y == x) {continue;}
                //check for end state
                if (nums[x] + nums[y] == target) {
                    int[] answers = {x,y};
                    return answers;}
            }
        }
        return null;

        
    }
}