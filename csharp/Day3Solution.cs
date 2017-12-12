using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AOC2015
{
    class Day3Solution : Solution
    {
        public override int Day => 3;
        public override string Name => "Day 3: Perfectly Spherical Houses in a Vacuum";

        public override void Run()
        {
            string input = File.ReadAllText("Input\\Day3Input.txt");

            Console.WriteLine($"Part 1 Answer Example 1: {Part1("^v")}");
            Console.WriteLine($"Part 1 Answer Example 2: {Part1("^>v<")}");
            Console.WriteLine($"Part 1 Answer Example 3: {Part1("^v^v^v^v^v")}");
            Console.WriteLine($"Part 1 Answer: {Part1(input)}");

            Console.WriteLine($"Part 2 Answer Example 1: {Part2("^v")}");
            Console.WriteLine($"Part 2 Answer Example 2: {Part2("^>v<")}");
            Console.WriteLine($"Part 2 Answer Example 3: {Part2("^v^v^v^v^v")}");
            Console.WriteLine($"Part 2 Answer: {Part2(input)}");
        }

        private int Part1(string input)
        {
            int x = 0, y = 0;
            Dictionary<string, int> visitLog = new Dictionary<string, int>();

            visitLog.Add("0,0",1); // starting position gets a present
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '<')
                    x--;
                else if (input[i] == '>')
                    x++;
                else if (input[i] == '^')
                    y++;
                else if (input[i] == 'v')
                    y--;

                var key = $"{x},{y}";
                if (visitLog.ContainsKey(key))
                    visitLog[key]++;
                else
                    visitLog.Add(key, 1);
            }
            return visitLog.Count;
        }

        private int Part2(string input)
        {
            int x = 0, y = 0, robo_x = 0, robo_y = 0;
            Dictionary<string, int> visitLog = new Dictionary<string, int>();

            visitLog.Add("0,0", 2); // starting position gets 2 presents
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    // Santa
                    if (input[i] == '<')
                        x--;
                    else if (input[i] == '>')
                        x++;
                    else if (input[i] == '^')
                        y++;
                    else if (input[i] == 'v')
                        y--;
                }
                else
                {
                    // Robo-Santa
                    if (input[i] == '<')
                        robo_x--;
                    else if (input[i] == '>')
                        robo_x++;
                    else if (input[i] == '^')
                        robo_y++;
                    else if (input[i] == 'v')
                        robo_y--;
                }

                var key = (i % 2 == 0 ? $"{x},{y}" : $"{robo_x},{robo_y}");
                if (visitLog.ContainsKey(key))
                    visitLog[key]++;
                else
                    visitLog.Add(key, 1);
            }
            return visitLog.Count;
        }
    }
}
