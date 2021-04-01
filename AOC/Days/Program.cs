using Days;
using System;

namespace Days
{
    class Program
    {
        static void Main(string[] args)
        {
            IDay day = new Day3();
            day.SetProgramInput();
            
            var result1 = day.RunPart1();
            Console.WriteLine($"Part 1 result is {result1}");

            var result2 = day.RunPart2();
            Console.WriteLine($"Part 2 result is {result2}");
        }
    }
}
