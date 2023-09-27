using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceleration_.Net_Second_Step_Tasks
{
    public static class Task5
    {
        public static int CountVariants(int stairCount)
        {
            if (stairCount < 0)
            {
                Console.WriteLine("Input can't be negative");
                return -1;
            }
            if (stairCount <= 1)
            {
                return 1;
            }

            int previousStep = 1;
            int currentStep = 1;

            for (int i = 2; i <= stairCount; i++)
            {
                int nextStep = previousStep + currentStep;
                previousStep = currentStep;
                currentStep = nextStep;
            }

            return currentStep;
        }
    }
}
