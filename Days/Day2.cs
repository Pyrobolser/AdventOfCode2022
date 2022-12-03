using System.IO;

namespace AdventOfCode2022.Days
{
    public static class Day2Part1
    {
        public static int Run()
        {
            var score = 0;
            foreach(var line in File.ReadLines("Inputs/Day2.txt"))
            {
                score += GetScore(line);
            }

            return score;
        }

        private static int GetScore(string round) => round switch
        {
            "A X" => 4,
            "A Y" => 8,
            "A Z" => 3,
            "B X" => 1,
            "B Y" => 5,
            "B Z" => 9,
            "C X" => 7,
            "C Y" => 2,
            "C Z" => 6,
            _ => throw new System.ArgumentOutOfRangeException(),
        };
    }

    public static class Day2Part2
    {
        public static int Run()
        {
            var score = 0;
            foreach (var line in File.ReadLines("Inputs/Day2.txt"))
            {
                score += GetScore(line);
            }

            return score;
        }

        private static int GetScore(string round) => round switch
        {
            "A X" => 3,
            "A Y" => 4,
            "A Z" => 8,
            "B X" => 1,
            "B Y" => 5,
            "B Z" => 9,
            "C X" => 2,
            "C Y" => 6,
            "C Z" => 7,
            _ => throw new System.ArgumentOutOfRangeException(),
        };
    }
}
