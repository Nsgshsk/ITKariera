using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public static class SortAndSearchAlgorithm
    {
        public static int SortAndBinarySearch(int[] nums, int x)
        {
            BubleSortDo(nums);
            int max = nums.Length - 1;
            int min = 0;
            while (min != max)
            {
                int mid = Convert.ToInt32(Math.Ceiling((min + max) / 2.0));
                if (nums[mid] > x) max = mid - 1;
                else min = mid;
            }
            if (nums[min] == x) return min;
            return -1;
        }
        public static bool SortAndBSContains(int[] nums, int x)
        {
            BubleSortDo(nums);
            int max = nums.Length - 1;
            int min = 0;
            while (min != max)
            {
                int mid = (min + max) / 2 + 1;
                if (x < nums[mid]) max = mid - 1;
                else min = mid;
            }
            if (nums[min] == x) return true;
            return false;
        }
        public static string Reapeat(string x, int n)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                stringBuilder.Append(x);
            }
            return stringBuilder.ToString();
        }
        public static void BubleSortFor(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                bool noSwap = true;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int tmp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = tmp;
                        noSwap = false;
                    }
                }
                if (noSwap) break;
            }
        }
        public static void BubleSortDo(int[] nums)
        {
            bool swap;
            //int n = nums.Length;
            do
            {
                swap = false;
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int tmp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = tmp;
                        swap = true;
                    }
                }
                //n--;
            } while (swap);
        }
    }
}
