/*
*File Name: ProblemJL.cs
*Name: Jenna Liette
*email: lietteja@mail.uc.edu
*Assignment Number: Final Project
*Due Date: 04/29/2025
*Course #/Section: IS3050/002
*Semester / Year: Spring 2025
*Brief Description of the assignment: Final group project showing mastery of C#. Each member finds a solution to a problem on LeetCode and compiles it into one Master file posted on Github.
*Brief Description of what this module does: Demonstrate mastery of basic C# programming and ASP.Net websites.
*Citations: https://leetcode.com/problems/burst-balloons/?envType=problem-list-v2&envId=array, https://www.perplexity.ai/search/using-c-write-a-code-to-solve-_9EISOrNSkePrDWwrWdf4g
*Anything else that's relevant: N/A
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gwen_FinalProject
{
    public class ProblemJL
    {
        public int MaxCoins(int[] nums)
        {
            int n = nums.Length;
            int[] balloons = new int[n + 2];
            balloons[0] = 1;
            balloons[n + 1] = 1;
            for (int i = 0; i < n; i++)
            {
                balloons[i + 1] = nums[i];
            }

            int[,] dp = new int[n + 2, n + 2];

            for (int length = 1; length <= n; length++)
            {
                for (int left = 1; left <= n - length + 1; left++)
                {
                    int right = left + length - 1;
                    for (int i = left; i <= right; i++)
                    {
                        dp[left, right] = Math.Max(dp[left, right],
                            dp[left, i - 1]
                            + balloons[left - 1] * balloons[i] * balloons[right + 1]
                            + dp[i + 1, right]);
                    }
                }
            }

            return dp[1, n];
        }
    }

}