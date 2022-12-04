using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2022.Days
{
    public static class Day3Part1
    {
        public static int Run()
        {
            var priorities = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            return File.ReadAllLines("Inputs/Day3.txt").Select(l => Array.IndexOf(priorities, l[..(l.Length / 2)].Intersect(l[(l.Length / 2)..]).Single()) + 1).Sum();
        }
    }

    public static class Day3Part2
    {
        public static int Run()
        {
            var priorities = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            var rucksacks = File.ReadAllLines("Inputs/Day3.txt");
            var total = 0;
            for(int i = 0; i < rucksacks.Length; i += 3)
            {
                total += Array.IndexOf(priorities, rucksacks[i].Intersect(rucksacks[i + 1]).Intersect(rucksacks[i + 2]).Single()) + 1;
            }

            return total;
        }
    }
}
