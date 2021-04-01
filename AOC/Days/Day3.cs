using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days
{
    class Day3 : BaseDay, IDay
    {
        private List<string> programInput;

        public Day3()
        {
            base.FetchRawInput(3);
        }

        public void SetProgramInput()
        {
            programInput = new List<string>();
            programInput = rawInput;
        }

        public int RunPart1()
        {
            return CalculateTreesOnSlope(3, 1);
        }

        public int RunPart2()
        {
            List<int> listRight = new List<int> {1, 3, 5, 7, 1};
            List<int> listDown = new List<int> {1, 1, 1, 1, 2};

            double product = 1;
            for(int x=0; x < listRight.Count; x++)
            {
                product *= CalculateTreesOnSlope(listRight[x], listDown[x]);
                Console.WriteLine($"Product at {x} is {product}");
            }

            return 1;
        }

        private int CalculateTreesOnSlope(int stepsRight, int stepsDown)
        {
            int currentX = 0;
            int treeCount = 0;

            for (int currentY = stepsDown; currentY < programInput.Count; currentY += stepsDown)
            {
                // Maximum value for currentX is programInput[currentY].Length - 1. If we get to programInput[currentY].Length then we are out of range
                if ((currentX + stepsRight) > (programInput[currentY].Length - 1))
                {
                    currentX = stepsRight - ((programInput[currentY].Length) % currentX);
                }
                else
                {
                    currentX += stepsRight;
                }

                if (programInput[currentY].ElementAt(currentX) == '#')
                {
                    treeCount++;
                }
            }

            return treeCount;
        }
    }
}
