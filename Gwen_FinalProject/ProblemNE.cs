
/*
*File Name: ProblemNE.cs
*Name: Nariah Edwards
*email: edwardn5@mail.uc.edu
*Assignment Number: Final Project
*Due Date: 04/24/2025
*Course #/Section: IS3050 Section -- 002
* Semester / Year: Spring 2025
*Brief Description of the assignment: This assignment counts as our final project for the class. We're practing working together through GitHub.
*Brief Description of what this module does: This final project causes students to excute what we've learned throughout the semester.
*Citations: https://stackoverflow.com/
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gwen_FinalProject
{
    public class ProblemNE
    {
        public void SolveSudoku(char[,] board)
        {
            Solve(board);
        }

        private bool Solve(char[,] board)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row, col] == '.')
                    {
                        for (char num = '1'; num <= '9'; num++)
                        {
                            if (IsValid(board, row, col, num))
                            {
                                board[row, col] = num;
                                if (Solve(board)) return true;
                                board[row, col] = '.';
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        private bool IsValid(char[,] board, int row, int col, char num)
        {
            // Check row and column
            for (int i = 0; i < 9; i++)
            {
                if (board[row, i] == num || board[i, col] == num)
                    return false;
            }

            // Check 3x3 box
            int boxStartRow = 3 * (row / 3);
            int boxStartCol = 3 * (col / 3);
            for (int i = boxStartRow; i < boxStartRow + 3; i++)
            {
                for (int j = boxStartCol; j < boxStartCol + 3; j++)
                {
                    if (board[i, j] == num) return false;
                }
            }
            return true;
        }
    }

}