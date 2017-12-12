using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2015
{
    class Day1Solution : Solution
    {
        public override int Day => 1;
        public override string Name => "Day 1: Not Quite Lisp";

        public override void Run()
        {
            string input = File.ReadAllText("Input\\Day1Input.txt");
            Console.WriteLine($"Part 1 Answer: {Part1(input)}");
            Console.WriteLine($"Part 2 Answer: {Part2(input)}");
        }

        private int Part1(string input)
        {
            int floor = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                    floor++;
                else if (input[i] == ')')
                    floor--;
            }
            return floor;
        }

        private int Part2(string input)
        {
            int floor = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                    floor++;
                else if (input[i] == ')')
                    floor--;

                if (floor == -1)
                    return i+1;
            }
            return -1;
        }
    }
}
