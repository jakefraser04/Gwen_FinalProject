namespace Gwen_FinalProject
{
    internal class ProblemJLBase
    {
        public int maxCoins(vector<int>&, nums)
        {
            int n = nums.size();
            vector<int> balloons(n +2, 1);

            for (int i = 0; i < n; i++)
            {
                balloons[i + 1] = nums[i];
            }

            vector<vector<int>> dp(n +2, vector<int>(n + 2, 0));

            for (int len = 1; len <= n; len++)
            {
                for (int left = 1; left <= n - len + 1; left++)
                {
                    int right = left + len - 1;
                    for (int last = left; last <= right; last++)
                    {
                        int coins = balloons[left - 1] * balloons[last] * balloons[right + 1]
                                  + dp[left][last - 1] + dp[last + 1][right];

                        dp[left][right] = max(dp[left][right], coins);
                    }
                }
            }

            return dp[1][n];
        }
    }
}