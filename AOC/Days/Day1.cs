using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days
{
    class Day1 : BaseDay, IDay
    {
        private List<int> programInput;

        public Day1()
        {
            base.FetchRawInput(1);
        }

        public void SetProgramInput()
        {
            programInput = new List<int>();
            foreach(string s in rawInput)
            {
                programInput.Add(int.Parse(s));
            }
        }

        public int RunPart1()
        {
            foreach (int i1 in programInput)
            {
                foreach (int i2 in programInput)
                {
                    if (i1 + i2 == 2020)
                    {
                        return i1 * i2;
                    }
                }
            }

            return -1;
        }

        public int RunPart2()
        {
            foreach (int i1 in programInput)
            {
                foreach (int i2 in programInput)
                {
                    foreach (int i3 in programInput)
                    {
                        if (i1 + i2 + i3 == 2020)
                        {
                            return i1 * i2 *i3;
                        }
                    }
                }
            }

            return -1;
        }
    }
}
