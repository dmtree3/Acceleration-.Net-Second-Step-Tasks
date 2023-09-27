using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceleration_.Net_Second_Step_Tasks
{
    public static class Task2
    {
        public static int MinSplit(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Inpute can't be a negative number");
                return 0;
            }

            int[] coins = { 50, 20, 10, 5, 1 };
            int coinCount = 0;

            for(int i = 0; i < coins.Length; i++)
            {
                coinCount += amount / coins[i];
                amount %= coins[i];
            }

            return coinCount;
        }
    }
}
