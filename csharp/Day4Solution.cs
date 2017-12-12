using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AOC2015
{
    class Day4Solution : Solution
    {
        public override int Day => 4;
        public override string Name => "Day 4: The Ideal Stocking Stuffer";

        public override void Run()
        {
            string input = "yzbqklnj"; // Puzzle Input

            Console.WriteLine($"Part 1 Answer: {Part1(input)}");
            Console.WriteLine($"Part 2 Answer: {Part2(input)}");
        }

        private int Part1(string input)
        {
            MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
            for (int i = 0; i < int.MaxValue; i++)
            {
                byte[] hashBytes = md5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(input + i));
                string hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                if (hash.StartsWith("00000"))
                    return i;
            }
            return -1;
        }

        private int Part2(string input)
        {
            MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
            for (int i = 0; i < int.MaxValue; i++)
            {
                byte[] hashBytes = md5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(input + i));
                string hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                if (hash.StartsWith("000000"))
                    return i;
            }
            return -1;
        }
    }
}
