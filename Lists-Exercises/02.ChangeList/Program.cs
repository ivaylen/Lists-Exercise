using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();

            while (input != "Odd" && input != "Even")
            {
                string[] commandArgs = input.Split(' ');
                switch (commandArgs[0])
                {
                    case "Delete":
                        int number = int.Parse(commandArgs[1]);
                        numbers.RemoveAll(x => x == number);
                        break;
                    case "Insert":
                        int index = int.Parse(commandArgs[2]);
                        int number1 = int.Parse(commandArgs[1]);

                        numbers.Insert(index, number1);
                        break;
                }
                input = Console.ReadLine();
            }
            if(input == "Odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                if(numbers[i] % 2 != 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
            if (input == "Even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
