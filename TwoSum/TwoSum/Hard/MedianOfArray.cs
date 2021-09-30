using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Hard
{
    public class MedianOfArray
    {
        public MedianOfArray()
        {
            var num1 = new int[] { 1, 3 };
            var num2 = new int[] { 2 };
            FindMedianSortedArrays(num1, num2);
        }
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int n1 = nums1.Length;
            int n2 = nums2.Length;
            if (n1 < n2) return FindMedianSortedArrays(nums2, nums1);

            int hi = 0, lo = n2 * 2;
            while (hi < lo)
            {
                int mid2 = (hi + lo) / 2;
                int mid1 = (n1 + n2) - mid2;

                double l1 = (mid1 == 0) ? int.MinValue : nums1[mid1 - 1] / 2;
                double l2 = (mid2 == 0) ? int.MinValue : nums2[mid2 - 1] / 2;

                //double r1 = (mid1 == n1 * 2) ? int.MaxValue : nums1[mid1] / 2;
                //double r2 = (mid2 == n2 * 2) ? int.MaxValue : nums2[mid2] / 2;

                //if (l1 < r2) lo = mid2 + 1;
                //else if (l2 > r1) hi = mid2 - 1;
                //else return (Math.Max(l1, l2) + Math.Min(r1, r2)) / 2;
                return (l1 + l2) / 2;
            }
            return -1;
            //int mergedArrayLen = nums1.Length + nums2.Length;
            //var num3 = new int[mergedArrayLen];
            //for (int i = 0; i < nums1.Length && i < nums2.Length; i++)
            //{
            //    //if (i < nums1.Length && i < nums2.Length)
            //    //{
            //    if (nums1[i] < nums2[i])
            //        num3[i] = nums1[i];
            //    else
            //        num3[i] = nums2[i];
            //    //}
            //    //else
            //    //{
            //    //    if (i < nums1.Length)
            //    //        num3[i] = nums1[i];
            //    //    if (i < nums2.Length)
            //    //        num3[i] = nums2[i];
            //    //}
            //    //var index = Array.FindIndex(nums2, x => x == nums1[i]);
            //    //if (index > -1)
            //    //    num3.Add(nums2[index]);
            //    //else
            //    //    num3.Add(nums1[i]);
            //}
            //double median;
            //if (num3.Length % 2 == 0)
            //    median = (num3[(num3.Length / 2) - 1] + num3[num3.Length / 2]) / 2;
            //else
            //    median = num3[num3.Length / 2];
            //return median;
            ////return num3.Count > 0 ? num3.Average() : 0.0;
        }
    }
}
