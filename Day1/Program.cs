using System;
using System.IO;
using System.Linq;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDepthIncreases = 0, numberOfDepthSlideIncreases = 0, slideSum = 0, previousSlideSum = 0;
            int[] data = Array.ConvertAll(File.ReadAllLines(@"Data.txt"), int.Parse);

            for(int i = 1; i < data.Length; i++)
            {
                numberOfDepthIncreases += (data[i] > data[i - 1]) ? 1 : 0;

                if (data.Length - i > 2)
                {
                    slideSum = data[i] + data[i + 1] + data[i + 2];
                    numberOfDepthSlideIncreases += (slideSum > previousSlideSum) ? 1 : 0;
                    previousSlideSum = slideSum;
                }
            }

            Console.WriteLine("Depth increases: " + numberOfDepthIncreases);
            Console.WriteLine("Depth slide increases: " + numberOfDepthSlideIncreases);
            Console.ReadLine();
        }
    }
}
