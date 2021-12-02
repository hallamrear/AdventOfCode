using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            int horizontal = 0;
            int depth = 0;
            string[] data = System.IO.File.ReadAllLines(@"Data.txt");

            foreach(string str in data)
            {
                string[] line = str.Split(" ");
                int amount = Convert.ToInt32(line[1]);

                switch(line[0])
                {
                    case "forward":
                        horizontal += amount;
                        break;
                    case "up":
                        depth -= amount;
                        break;
                    case "down":
                        depth += amount;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Depth: " + depth);
            Console.WriteLine("Horizontal: " + horizontal);
            Console.WriteLine("Multiplied: " + (horizontal * depth));
            Console.ReadLine();
        }
    }
}
