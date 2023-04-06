using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.alirezab.LeetCodeProblems.Easy;
internal sealed class BinarySearch
{
    public int Search(int[] nums, int target)
    {
        int l = 0, h = nums.Length - 1;
        while (l <= h)
        {
            int m = l + (h - l >> 1);
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
        return -1;
    }
}
