using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceleration_.Net_Second_Step_Tasks
{
    public static class Task4
    {
        public static bool IsProperly(string sequence)
        {
            int counter = 0;

            foreach(char x in sequence)
            {
                if (x == '(')
                {
                    counter++;
                }

                else if (x == ')')
                {
                    counter--;

                    if (counter < 0)
                    {
                        return false;
                    }
                }
            }

            return counter == 0;
        }
    }
}
