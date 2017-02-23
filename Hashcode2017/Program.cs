using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashcode2017
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputGenerator.CreateOutput("out", new List<List<int>> { new List<int> { 0, 2 }, new List<int> { 1, 3, 1 }, new List<int> { 2, 0, 1 } });
        }
    }
}
