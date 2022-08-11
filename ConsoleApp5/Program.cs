using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 3, };

            //int maxNumber = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            int[] numbers = { 12, 21, 33, 42, 55 };
            int sum = 0;
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 21 == 0)
                {
                    sum += numbers[i];
                    count++;
                }
            }
            if (count != 0)
            {
                int result = sum / count;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Arrayde 21-e bolunen eded yoxdur");
            }


        }
    }
}
