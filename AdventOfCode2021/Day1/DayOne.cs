using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day1
{
    internal static class DayOne
    {
        // Part 1
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

        //Part 2
        public static int GetIncreasingMeasurementBasedOnSlidingWindows(IReadOnlyList<int> measurements)
        {
            var slidingWindows = BuildSlidingWindows(measurements);
            var increasingMeasurements = 0;
            var containsPreviousToCompareWith = 1;
            for (var currentIndex = containsPreviousToCompareWith; currentIndex < slidingWindows.Count; currentIndex++)
            {
                var currentSlidingWindow = slidingWindows[currentIndex];
                var previousSlidingWindow = slidingWindows[currentIndex - 1];
                if (currentSlidingWindow.Sum() > previousSlidingWindow.Sum())
                {
                    increasingMeasurements++;
                }
            }

            return increasingMeasurements;
        }

        private static IReadOnlyList<IReadOnlyList<int>> BuildSlidingWindows(IReadOnlyList<int> measurements)
        {
            var list = new List<List<int>>();
            for (var currentIndex = 0; currentIndex < measurements.Count; currentIndex++)
            {
                var nextElementIndex = currentIndex + 1;
                // :))
                var nextAfterwardsIndex = currentIndex + 2;
                if (nextElementIndex >= measurements.Count || nextAfterwardsIndex >= measurements.Count)
                {
                    break;
                }

                list.Add(new List<int> { measurements[currentIndex], measurements[nextElementIndex], measurements[nextAfterwardsIndex] });
            }

            return list;
        }
    }
}
