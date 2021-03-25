using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Days
{
    class BaseDay
    {
        public List<string> rawInput;

        public void FetchRawInput(int day)
        {
            rawInput = AOCUtils.ReadFile("C:/Code/GitHub/cesar-younes/advent-of-code-2020-dotnet/AOC/Days/inputs/day" + day + ".txt");
        }
    }
}
