using System;
using System.Collections.Generic;

namespace CountOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 0, 1, 5, 8, 15, 19, 25, 50, 100, 333, 500, 666, 750, 1000 };
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number} has {CountOnes(number)} ones in it's binary representation ({Convert.ToString(number, 2)})");
            }
        }

        static int CountOnes(int number)
        {
            var count = 0;
            for (var powerOfTwo = 0; powerOfTwo < 32; powerOfTwo += 1)
            {
                if ((number & PowerOfTwo(powerOfTwo)) != 0)
                {
                    count += 1;
                }
            }
            return count;
        }

        private static int PowerOfTwo(int powerOfTwo)
        {
            return (int)Math.Pow(2, powerOfTwo);
        }
    }
}
