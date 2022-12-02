using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2022.Days
{
    internal static class Day1Part1
    {
        public static int Run()
        {
            int max = 0, calories = 0;
            foreach(var line in File.ReadAllLines("Inputs/Day1.txt"))
            {
                if (string.IsNullOrEmpty(line))
                {
                    max = calories > max ? calories : max;
                    calories = 0;
                    continue;
                }

                calories += int.Parse(line);
            }

            return max;
        }
    }

    internal static class Day1Part2
    {
        public static int Run()
        {
            int calories = 0;
            List<int> elves = new();
            foreach (var line in File.ReadAllLines("Inputs/Day1.txt"))
            {
                if (string.IsNullOrEmpty(line))
                {
                    elves.Add(calories);
                    calories = 0;
                    continue;
                }

                calories += int.Parse(line);
            }

            return elves.OrderByDescending(e => e).Take(3).Sum();
        }
    }
}
