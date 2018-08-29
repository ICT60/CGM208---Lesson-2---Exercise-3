using System;

namespace CGM208___Lesson2___Exercise_3
{
    class Program
    {
        const uint BASE_NUMBER = 2;
        const uint MIN_MULTIPLIER = 1;
        const uint MAX_MULTIPLIER = 100;
        const string MULTIPLY_TABLE_FORMAT = "{0} x {1} = {2}";

        static void Main(string[] args)
        {
            PrintMultiplyTable(BASE_NUMBER, MIN_MULTIPLIER, MAX_MULTIPLIER);
            Console.ReadLine();
        }

        static void PrintMultiplyTable(uint baseNumber, uint multipiler, uint maxMultiplier)
        {
            if (multipiler <= maxMultiplier) {
                string result = GetMultiplyTable(baseNumber, multipiler);
                Console.WriteLine(result);
                PrintMultiplyTable(baseNumber, multipiler + 1, maxMultiplier);
            }
        }

        static string GetMultiplyTable(uint baseNumber, uint multipiler)
        {
            uint result = (baseNumber * multipiler);
            string textResult = string.Format(MULTIPLY_TABLE_FORMAT, baseNumber, multipiler, result);
            return textResult;
        }
    }
}
