using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchforaNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var commandArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = numbers.Take(commandArgs[0]).ToList();
            result.RemoveRange(0, commandArgs[1]);

            if (result.Contains(commandArgs[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
