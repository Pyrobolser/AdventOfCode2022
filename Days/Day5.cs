using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2022.Days
{
    public static class Day5Part1
    {
        public static string Run()
        {
            var isMoves = false;
            Stack<char>[] stacks = Enumerable.Range(0, 9).Select(s => new Stack<char>()).ToArray();
            foreach(var line in File.ReadLines("Inputs/Day5.txt"))
            {
                if (string.IsNullOrEmpty(line))
                {
                    isMoves = true;
                    for (int i = 0; i < stacks.Length; i++)
                        stacks[i] = new Stack<char>(stacks[i]);
                    continue;
                }
                else if (isMoves)
                {
                    var regex = new Regex("[0-9]+", RegexOptions.Compiled);
                    var moves = regex.Matches(line).Select(i => int.Parse(i.Value)).ToArray();

                    for (int i = 0; i < moves[0]; i++)
                        stacks[moves[2] - 1].Push(stacks[moves[1] - 1].Pop());
                }
                else
                {
                    var regex = new Regex("[A-Z]", RegexOptions.Compiled);
                    foreach(Match match in regex.Matches(line))
                    {
                        stacks[(match.Index - 1) / 4].Push(match.Value[0]);
                    }
                }
            }
            
            return new string(stacks.Select(s => s.Pop()).ToArray());
        }
    }

    public static class Day5Part2
    {
        public static string Run()
        {
            var isMoves = false;
            Stack<char>[] stacks = Enumerable.Range(0, 9).Select(s => new Stack<char>()).ToArray();
            var temp = new Stack<char>();
            foreach (var line in File.ReadLines("Inputs/Day5.txt"))
            {
                if (string.IsNullOrEmpty(line))
                {
                    isMoves = true;
                    for (int i = 0; i < stacks.Length; i++)
                        stacks[i] = new Stack<char>(stacks[i]);
                    continue;
                }
                else if (isMoves)
                {
                    var regex = new Regex("[0-9]+", RegexOptions.Compiled);
                    var moves = regex.Matches(line).Select(i => int.Parse(i.Value)).ToArray();
                    
                    for (int i = 0; i < moves[0]; i++)
                        temp.Push(stacks[moves[1] - 1].Pop());

                    while (temp.Any())
                        stacks[moves[2] - 1].Push(temp.Pop());
                }
                else
                {
                    var regex = new Regex("[A-Z]", RegexOptions.Compiled);
                    foreach (Match match in regex.Matches(line))
                    {
                        stacks[(match.Index - 1) / 4].Push(match.Value[0]);
                    }
                }
            }

            return new string(stacks.Select(s => s.Pop()).ToArray());
        }
    }
}
