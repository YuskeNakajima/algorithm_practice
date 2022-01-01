using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Utility
{
    public static class Functions
    {
        public static void ListWriteLine(string label, List<int> numbers)
        {
            Console.Write($"{label}: ");
            numbers.ForEach(item => Console.Write($"{item:000} "));
            Console.WriteLine();
        }

        public static List<int> RandomList(int length, int minValue, int maxValue)
        {
            Random r = new();
            return Enumerable.Range(1, length)
                .Select(_ => r.Next(minValue, maxValue))
                .ToList();
        }
    }
}