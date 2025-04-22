using System.Xml.Linq;
/*
*File Name: ProblemJF.cs

*Name: Jake Fraser
*email:  fraserjk@mail.uc.edu
*Assignment Number: Final Project
*Due Date: 4/29/2025
*Course #/Section:   IS 3050 Section 002
* Semester / Year:   Spring 2025
*Brief Description of the assignment:  Solve Problem 42: Trapping Rain Water on Leet Code.

*Brief Description of what this module does. Using asp.net collaboratively to build a functional website 
*Citations: { Link to specific pages. "StackOverflow" or "w3Schools" is not sufficient. }
*Anything else that's relevant:
*/

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

