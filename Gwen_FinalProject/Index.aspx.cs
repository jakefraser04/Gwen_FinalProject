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

        }

        protected void cmdTJ_Click(object sender, EventArgs e)
        {
            char[][] matrix =
            {
                new char[] { '1', '0', '1', '0', '0' },
                new char[] { '1', '0', '1', '1', '1' },
                new char[] { '1', '1', '1', '1', '1' },
                new char[] { '1', '0', '0', '1', '0' }

            };
            //int result = int.maxArea.MaximalRectangle(matrix);
            //Console.WriteLine("The largest rectangle's areas is:" + result);
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

            lblResult.Text = "Maximum Coins Collected: " + maxCoins;
        }
    }
}