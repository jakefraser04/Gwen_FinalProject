/*
*File Name: Index.aspx.cs
*Name: Jake Fraser
*email: fraserjk@mai.uc.edu
*Assignment Number: Final Project
*Due Date: 04/29/2025
*Course #/Section: IS3050 Section -- 002
* Semester / Year: Spring 2025
*Brief Description of the assignment: This assignment is our final project for the class. We are creating a website with each of our leetcode solutions.
*Brief Description of what this module does: This final project causes students to excute what we've learned throughout the semester.
*Citations: https://stackoverflow.com/ 
https://stackoverflow.com/questions/33588265/making-a-matrix
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gwen_FinalProject
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdJF_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int n = rand.Next(5, 21); // Random length between 5 and 20
            int[] height = new int[n];
            for (int i = 0; i < n; i++)
                height[i] = rand.Next(0, 5); // Heights between 0 and 4

            ProblemJF problem = new ProblemJF();
            int trappedWater = problem.Trap(height);

            lblExplanation.Text = "Given n non-negative integers representing an elevation map where the width of each bar is 1, we can compute how much water is left trapped after a rainfall.";
            lblResult.Text = $"Random heights: [{string.Join(", ", height)}]<br/>" +
                             $"Trapped Water Units: {trappedWater}";
        }

        protected void cmdTJ_Click(object sender, EventArgs e)
        {

            Random rand = new Random();

            
            int rows = rand.Next(2, 7); 
            int cols = rand.Next(2, 7); 
            char[][] matrix = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new char[cols];
                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = rand.Next(2) == 0 ? '0' : '1';
                }
            }
                var ProblemTJ = new ProblemTJ();
            int area = ProblemTJ.MaximalRectangle(matrix);
            string matrixStr = "";
            for (int i = 0; i < rows; i++)
            { 
             matrixStr = string.Join(" ", matrix[i]) + "<br/>";

            lblResult.Text = $"Random Matrix:<br/>{matrixStr}<br/>" +
                      $"Maximal Rectangle Area: {area}";
                lblExplanation.Text = "Given a binary matrix (rows and columns) containing only 0s and 1s, find the area of the largest rectangle that is entirely made up of 1s.";


            }

        }


        protected void cmdNE_Click(object sender, EventArgs e)
        {
            char[,] board = new char[9, 9];
            // Initialize all cells to '.'
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    board[i, j] = '.';

            Random rand = new Random();

            // Randomly fill 10 cells with random digits (1-9), checking validity
            int filled = 0;
            while (filled < 10)
            {
                int row = rand.Next(0, 9);
                int col = rand.Next(0, 9);
                if (board[row, col] == '.')
                {
                    char num = (char)('1' + rand.Next(0, 9));
                    // Check if valid
                    bool valid = true;
                    for (int i = 0; i < 9; i++)
                        if (board[row, i] == num || board[i, col] == num)
                            valid = false;
                    int boxRow = 3 * (row / 3), boxCol = 3 * (col / 3);
                    for (int i = boxRow; i < boxRow + 3; i++)
                        for (int j = boxCol; j < boxCol + 3; j++)
                            if (board[i, j] == num)
                                valid = false;
                    if (valid)
                    {
                        board[row, col] = num;
                        filled++;
                    }
                }
            }

            ProblemNE solver = new ProblemNE();
            solver.SolveSudoku(board);

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sb.Append(board[i, j]);
                    sb.Append(' ');
                }
                sb.Append("<br/>");
            }
            lblExplanation.Text = "This solution will generate a randomized sudoku board!";
            lblResult.Text = sb.ToString();
        }

        protected void cmdJL_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int n = rand.Next(1, 301);
            int[] nums = new int[n];

            for (int i=0; i<n; i++)
                nums[i] = rand.Next(0, 101);

            ProblemJL problemJL = new ProblemJL();
            int maxCoins = problemJL.MaxCoins(nums);

            string balloonsStr = string.Join(", ", nums);

            lblExplanation.Text = "You have up to 300 balloons, each labeled with a number between 0 and 100. Your goal is to pop them all in the best order to collect the most coins. When you pop a balloon, you earn coins based on the numbers of its left and right neighbors. If a balloon has no neighbor (because you're at the edge), imagine a balloon with the number 1 is there.";
            lblResult.Text = $"Random Balloons: [{balloonsStr}]<br/>" +
                             $"Maximum Coins Collected: {maxCoins}";
        }
    }
}