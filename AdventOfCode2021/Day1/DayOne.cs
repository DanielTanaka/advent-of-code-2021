using System.Collections.Generic;

namespace AdventOfCode2021.Day1
{
    internal static class DayOne
    {
        public static int GetIncreasingMeasurementsQuantity(IReadOnlyList<int> measurements)
        {
            var increasingMeasurements = 0;
            var containsPreviousToCompareWith = 1;
            for (var currentIndex = containsPreviousToCompareWith; currentIndex < measurements.Count; currentIndex++)
            {
                var currentMeasurement = measurements[currentIndex];
                var previousMeasurementIndex = currentIndex - 1;
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
