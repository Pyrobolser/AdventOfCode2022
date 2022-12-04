using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2022.Days
{
    public static class Day4Part1
    {
        public static int Run()
        {
            var pairs = 0;
            foreach (var line in File.ReadLines("Inputs/Day4.txt"))
            {
                var sections = Array.ConvertAll(line.Split(',').SelectMany(l => l.Split('-')).ToArray(), int.Parse);
                if ((sections[0] <= sections[2] && sections[3] <= sections[1]) || 
                    (sections[2] <= sections[0] && sections[1] <= sections[3]))
                    pairs++; 
            }

            return pairs;
        }
    }

    public static class Day4Part2
    {
        public static int Run()
        {
            var pairs = 0;
            foreach (var line in File.ReadLines("Inputs/Day4.txt"))
            {
                var sections = Array.ConvertAll(line.Split(',').SelectMany(l => l.Split('-')).ToArray(), int.Parse);
                if ((sections[2] <= sections[1] && sections[1] <= sections[3]) ||
                    (sections[0] <= sections[3] && sections[3] <= sections[1]))
                    pairs++;
            }

            return pairs;
        }
    }
}