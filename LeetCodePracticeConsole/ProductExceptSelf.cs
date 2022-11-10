using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodePracticeConsole
{
    public class ProductExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums) {
            //if null or empty do nothing
            if (nums == null || nums.Length == 0)
                return null;
                //create holder array for storing
            int[] result = new int[nums.Length];
            //temp value to hold fake spot
            int temp = 1;
            //multiply to the right of each variable and place it in equivalent holder spot
            for (int i = 0; i < nums.Length; i++)
            {
                //in each spot put the temp variable
                result[i] = temp;
                //multiply temp by the current spot
                temp *= nums[i];
            }
            //reset temp to one
            temp = 1;
            //multiply everything to the left of a number and put it in its appropriate start
            for (int i = result.Length - 1; i >= 0; i--)
            {
                //same as first loop but starting from the end
                result[i] *= temp;
                temp *= nums[i];
            }
            //return holder
            return result;
        }
    }
}