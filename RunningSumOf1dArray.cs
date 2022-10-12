//Given an array nums.
// We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
//Return the running sum of nums.
//Ex.
//Input: nums = [1,2,3,4]
//Output: [1,3,6,10]
//Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
using System;


public class Solution {

    public static void Main(string[] args)
    {
        int holder[] = [1,2,3,4];
        Console.WriteLine();
    }

    public int[] RunningSum(int[] nums) {
        for (int i = 1; i<nums.Length; i++){
            //add current spot to last spot, ignore first spot since it cant add itself to nothing
            nums[i] += nums[i-1];
        }
        //send it
        return nums;
    }
}