using System;
using System.IO;
using System.Linq;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDepthIncreases = 0;
            int[] data = Array.ConvertAll(File.ReadAllLines(@"Data.txt"), int.Parse);

            for(int i = 1; i < data.Length; i++)
            {
                if(data[i] > data[i - 1])
                    numberOfDepthIncreases++;
            }

            Console.WriteLine("Depth increases: " + numberOfDepthIncreases);
            Console.ReadLine();
        }
    }
}
