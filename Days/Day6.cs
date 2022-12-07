using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2022.Days
{
    public static class Day6
    {
        public static int Run(int length)
        {
            var data = File.ReadAllText("Inputs/Day6.txt").AsSpan();
            var index = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data.Slice(i, length).ToArray().ToHashSet().Count == length)
                {
                    index = i + length;
                    break;
                }
            }

            return index;
        }
    }
}
