/* 
# File Name : ProblemTJ.cs
# Student Name: Taylor Johnson
# email:  johns7tr@mail.uc.edu
# Assignment Number: Final Project
# Due Date:   4/29/25
# Course #/Section:   Section 02
# Semester/Year:   Spring 2025
# Brief Description of the assignment: Use Leetcode and solve a selected problem listed as hard. The problem being solved was problem 85 
named Maximal Rectangle. 

# Brief Description of what this module does. This module takes the concepts from HTML, CSS, and C# and applies them to ASP.Net. 
# Citations: https://leetcode.com/problems/maximal-rectangle/ ,https://www.perplexity.ai/search/you-are-given-an-array-of-inte-9VLYLhQ8SqCrOOMMelM1Zg

# Anything else that's relevant: N/A

 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gwen_FinalProject
{
    public class ProblemTJ
    {


        
            public int MaximalRectangle(char[][] matrix)
            {
                if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                    return 0;

                int rows = matrix.Length;
                int cols = matrix[0].Length;
                int[] heights = new int[cols];
                int maxArea = 0;

                for (int i = 0; i < rows; i++)
                {
                    // Build the histogram for this row
                    for (int j = 0; j < cols; j++)
                    {
                        if (matrix[i][j] == '1')
                        {
                            heights[j] += 1;
                        }
                        else
                        {
                            heights[j] = 0;
                        }
                    }
                    // Update max area with the largest rectangle in the histogram
                    maxArea = Math.Max(maxArea, LargestRectangleArea(heights));
                }
                return maxArea;
            }

            private int LargestRectangleArea(int[] heights)
            {
                int maxArea = 0;
                Stack<int> stack = new Stack<int>();
                int[] extendedHeights = new int[heights.Length + 1];
                heights.CopyTo(extendedHeights, 0);

                for (int i = 0; i < extendedHeights.Length; i++)
                {
                    while (stack.Count > 0 && extendedHeights[i] < extendedHeights[stack.Peek()])
                    {
                        int height = extendedHeights[stack.Pop()];
                        int width = stack.Count == 0 ? i : i - stack.Peek() - 1;
                        maxArea = Math.Max(maxArea, height * width);
                    }
                    stack.Push(i);
                }
                return maxArea;
            }
        }


 }



