using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gwen_FinalProject
{
    public class ProblemJF
    {
        public int Trap(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int leftMax = 0, rightMax = 0;
            int result = 0;

            while (left < right)
            {
                if (height[left] < height[right])
                {
                    if (height[left] >= leftMax)
                    {
                        leftMax = height[left];
                    }
                    else
                    {
                        result += leftMax - height[left];
                    }
                    left++;
                }
                else
                {
                    if (height[right] >= rightMax)
                    {
                        rightMax = height[right];
                    }
                    else
                    {
                        result += rightMax - height[right];
                    }
                    right--;
                }
            }
            return result;
        }
    }
}

