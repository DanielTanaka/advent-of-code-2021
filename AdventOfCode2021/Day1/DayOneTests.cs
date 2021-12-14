using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace AdventOfCode2021.Day1
{
    public class DayOneTests
    {
        private static readonly IReadOnlyList<int> Measurements = 
            new List<int> { 199, 200, 208, 210, 200, 207, 240, 269, 269, 260, 263, 263 };
        private static readonly IReadOnlyList<int> NonIncreasingMeasurements =
            new List<int> { 200, 198, 194, 100, 10, 5 };

        // Part 1
        [Fact]
        public void GetIncreasingMeasurementsQuantity_WithIncreasingMeasurements_ShouldCountProperly()
        {
            var increasingMeasurementsCounter = DayOne.GetIncreasingMeasurementsQuantity(Measurements);
            var expectedCounter = 7;

            increasingMeasurementsCounter.Should().Be(expectedCounter);
        }

        [Fact]
        public void GetIncreasingMeasurementsQuantity_WithNoIncreasingMeasurements_ShouldReturnZero()
        {
            var increasingMeasurementsCounter = DayOne.GetIncreasingMeasurementsQuantity(NonIncreasingMeasurements);

            increasingMeasurementsCounter.Should().Be(0);
        }

        // Part 2
        [Fact]
        public void GetIncreasingMeasurementBasedOnSlidingWindows_WithIncreasingMeasurements_ShouldCountProperly()
        {
            var increasingMeasurementsQuantity = DayOne.GetIncreasingMeasurementBasedOnSlidingWindows(Measurements);
            var expectedCounter = 5;

            increasingMeasurementsQuantity.Should().Be(expectedCounter);
        }

        [Fact]
        public void GetIncreasingMeasurementBasedOnSlidingWindows_WithNoIncreasingMeasurement_ShouldReturnZero()
        {
            var increasingMeasurementsCounter = DayOne.GetIncreasingMeasurementBasedOnSlidingWindows(NonIncreasingMeasurements);

            increasingMeasurementsCounter.Should().Be(0);
        }
    }
}
