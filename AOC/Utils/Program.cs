using System;
using System.Collections.Generic;

namespace Utils
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> result = AOCUtils.ReadFile("../../../../Days/inputs/day1.txt");
            foreach(string s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}
