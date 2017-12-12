using System;
using System.IO;

namespace AOC2015
{
    class Day2Solution : Solution
    {
        public override int Day => 2;
        public override string Name => "Day 2: I Was Told There Would Be No Math";

        public override void Run()
        {
            string[] input = File.ReadAllLines("Input\\Day2Input.txt");

            Console.WriteLine($"Part 1 Answer Example 1: {Part1(new string[] { "2x3x4" })}");
            Console.WriteLine($"Part 1 Answer Example 2: {Part1(new string[] { "1x1x10" })}");
            Console.WriteLine($"Part 1 Answer: {Part1(input)}");

            Console.WriteLine($"Part 2 Answer Example 1: {Part2(new string[] { "2x3x4" })}");
            Console.WriteLine($"Part 2 Answer Example 2: {Part2(new string[] { "1x1x10" })}");
            Console.WriteLine($"Part 2 Answer: {Part2(input)}");
        }

        private int Part1(string[] input)
        {
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int[] args = Array.ConvertAll(input[i].Split('x'), s => int.Parse(s));

                int length = args[0], width = args[1], height = args[2];
                int area = 2 * length * width + 2 * width * height + 2 * height * length;
                int extra = Math.Min(length * width, Math.Min(width * height, height * length));

                result += area + extra;
            }

            return result;
        }

        private int Part2(string[] input)
        {
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int[] args = Array.ConvertAll(input[i].Split('x'), s => int.Parse(s));

                int length = args[0], width = args[1], height = args[2];
                int ribbonLength = Math.Min(length * 2 + width * 2, Math.Min(width * 2 + height * 2, length * 2 + height * 2));
                int bowLength = length * width * height;

                result += ribbonLength + bowLength;
            }

            return result;
        }
    }
}