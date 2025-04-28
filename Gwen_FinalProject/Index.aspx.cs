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
               
            }

        }


        protected void cmdNE_Click(object sender, EventArgs e)
        {
           
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