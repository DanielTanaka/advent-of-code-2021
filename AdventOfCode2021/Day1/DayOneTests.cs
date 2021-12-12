using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace AdventOfCode2021.Day1
{
    public class DayOneTests
    {
        [Theory]
        [MemberData(nameof(GetIncreasingMeasurements), MemberType = typeof(DayOneTests))]
        public void GetIncreasingMeasurementsQuantity_WithIncreasingMeasurements_ShouldCountProperly(IReadOnlyList<int> measurements, int expectedCounter)
        {
            var increasingMeasurementsCounter = DayOne.GetIncreasingMeasurementsQuantity(measurements);

            increasingMeasurementsCounter.Should().Be(expectedCounter);
        }

        [Theory]
        [MemberData(nameof(GetNonIncreasingMeasurements), MemberType = typeof(DayOneTests))]
        public void GetIncreasingMeasurementsQuantity_WithNoIncreasingMeasurements_ShouldReturnZero(IReadOnlyList<int> measurements)
        {
            var increasingMeasurementsCounter = DayOne.GetIncreasingMeasurementsQuantity(measurements);

            increasingMeasurementsCounter.Should().Be(0);
        }

        public static IEnumerable<object[]> GetIncreasingMeasurements()
        {
            yield return new object[] { new List<int> { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 }, 7 };
            yield return new object[] { new List<int> { 200, 202, 204, 206, 208 }, 4 };
        }

        public static IEnumerable<object[]> GetNonIncreasingMeasurements()
        {
            yield return new object[] { new List<int> { 200, 198, 194, 100, 10 } };
        }
    }
}
