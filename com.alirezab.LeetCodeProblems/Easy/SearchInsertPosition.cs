using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.alirezab.LeetCodeProblems.Easy;
internal sealed class SearchInsertPosition
{
    /*Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [1,3,5,6], target = 5
Output: 2

Example 2:

Input: nums = [1,3,5,6], target = 2
Output: 1

Example 3:

Input: nums = [1,3,5,6], target = 7
Output: 4

 

Constraints:

    1 <= nums.length <= 104
    -104 <= nums[i] <= 104
    nums contains distinct values sorted in ascending order.
    -104 <= target <= 104

*/
    public int SearchInsert(int[] nums, int target)
    {
        int l = 0, h = nums.Length - 1;
        int m = 0;
        while (l <= h)
        {
            m = l + (h - l >> 1);
            if (nums[m] == target)
            {
                return m;
            }
            if (nums[m] < target)
            {
                l = m + 1;
            }
            else
            {
                h = m - 1;
            }
        }
        if (nums[m] < target)
        {
            return m + 1;
        }
        return m;
    }
}
