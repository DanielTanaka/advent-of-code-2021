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
                var measurements = Parser.GetIntegersListFromFile(filePath);
                var increasingMeasurementsQuantity = DayOne.GetIncreasingMeasurementsQuantity(measurements);
                var basedOnSlidingWindows = DayOne.GetIncreasingMeasurementBasedOnSlidingWindows(measurements);
                Console.WriteLine($"Part 1: Quantity of increasing measurements: {increasingMeasurementsQuantity}");
                Console.WriteLine($"Part 2: Quantity of increasing measurements based on Sliding Windows: {basedOnSlidingWindows}");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
