using System.Collections.Generic;

namespace AdventOfCode2021.Day1
{
    internal static class DayOne
    {
        public static int GetIncreasingMeasurementsQuantity(IReadOnlyList<int> measurements)
        {
            var increasingMeasurements = 0;
            for (var currentIndex = 0; currentIndex < measurements.Count; currentIndex++)
            {
                if (currentIndex <= 0)
                {
                    continue;
                }

                var previousMeasurementIndex = currentIndex - 1;
                var currentMeasurement = measurements[currentIndex];
                var previousMeasurement = measurements[previousMeasurementIndex];
                if (currentMeasurement > previousMeasurement)
                {
                    increasingMeasurements++;
                }
            }

            return increasingMeasurements;
        }
    }
}
