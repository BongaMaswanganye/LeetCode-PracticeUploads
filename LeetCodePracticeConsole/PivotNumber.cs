using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodePracticeConsole
{
    //to execute this file,in the terminal run:>dotnet build LeetCodePracticeConsole.csproj -p:StartupObject=LeetCodePracticeConsole.PivotNumber
    //Given an array of integers nums, calculate the pivot index of this array.
    //The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum of all the numbers strictly to the index's right.
    //If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left. This also applies to the right edge of the array.
    //Return the leftmost pivot index. If no such index exists, return -1.
    public class PivotNumber
    {
        public static void Main (String[] args)
        {
            int[] holder = {5,5,5,5,5};
            Console.WriteLine(PivotIndex(holder));
        }



        public static int PivotIndex(int[] nums) {
        //if its 1 variable return the 0 spot cause both sides of it are the same
        if (nums.Length == 1) {return 0;}
        //starting from 0 place, there is no value to its left so start at 0
        int left = 0;
        //get total of everything to the right of the 1st index of the array
        int right = nums.Sum() - nums[0];
        //if the entire array is 0 then return out
        if (left == right) {return 0;}

        //starting from the 2nd index go to the end
        for (int i = 1; i < nums.Length; i++){  
            //get number to the left of current pivot and add it to left variable
            left += nums[i-1];
            //subtract number from the right variable of the current pivot
            right -= nums[i];
            
            //if this is the pivot send the index
            if (left == right){
                return i;
            }
        }
        //if it goes through the entire loop and doesnt return then send -1
        return -1;
        }
    }
}