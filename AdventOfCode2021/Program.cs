using AdventOfCode2021.Day1;
using AdventOfCode2021.Helpers;
using System;

namespace AdventOfCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var filePath = @"";
                var measurements = Parser.GetIntegerListFromFile(filePath);
                var increasingMeasurementsQuantity = DayOne.GetIncreasingMeasurementsQuantity(measurements);
                Console.WriteLine($"Quantity of increasing measurements: {increasingMeasurementsQuantity}");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
