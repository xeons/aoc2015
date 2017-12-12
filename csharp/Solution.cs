using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2015
{
    abstract class Solution
    {
        public abstract string Name { get; }
        public abstract int Day { get; }
        public abstract void Run();
    }
}
