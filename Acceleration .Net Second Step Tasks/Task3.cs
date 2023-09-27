using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceleration_.Net_Second_Step_Tasks
{
    public static class Task3
    {
        public static int NotContains(int[] array)
        {
            for (int i = 1; i <= int.MaxValue ; i++)
            {
                if (!array.Contains(i))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
