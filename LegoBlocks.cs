using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoBlocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine().Trim());

            int[][] firstJaggedArray = new int[number][];
            int[][] secondJaggedArray = new int[number][];
            bool sameLengthOfCols = true;
            var length = new int[number];

            for (int rowIndex = 0; rowIndex < number; rowIndex++)
            { 
                var rows = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                firstJaggedArray[rowIndex] =  rows;
                length[rowIndex] = firstJaggedArray[rowIndex].Length;

            }

            for (int rowIndex = 0; rowIndex < number; rowIndex++)
            {
                var rows = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse().ToArray();
                secondJaggedArray[rowIndex] = rows;
                length[rowIndex] += secondJaggedArray[rowIndex].Length;
            }

            for (int i = 0; i < length.Length - 1; i++)
            {
                if(length[i] != length[i+1])
                {
                    sameLengthOfCols = false;
                  Console.WriteLine($"The total number of cells is: {length.Sum()}");
                    break;
                }
            }

            if (sameLengthOfCols)
            {
                int[][] matchedArray = new int[number][];

                for (int i = 0; i < number; i++)
                {
                    matchedArray[i] = (firstJaggedArray[i].Concat(secondJaggedArray[i]).ToArray());
                }

                foreach (var item in matchedArray)
                {
                    Console.WriteLine("[{0}]", string.Join(", ", item));
                }
            }         
        }
    }
}
