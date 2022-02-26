using System;
using Xunit;
using Helpers;

namespace Helpers.Tests
{
    public class DayOfWeekHelpersTests
    {
        [Fact]
        public void CountDaysBetweenCarryIntoNextWeekTest()
        {
            var result = DayOfWeekHelpers.CountDaysBetween(DayOfWeek.Friday, DayOfWeek.Monday);
            Assert.Equal(3, result);
        }

        [Fact]
        public void CountDaysBetweenSameWeekTest()
        {
            var result = DayOfWeekHelpers.CountDaysBetween(DayOfWeek.Monday, DayOfWeek.Friday);
            Assert.Equal(4, result);
        }

        [Fact]
        public void AddDaysCarryIntoNextWeekTest()
        {
            var result = DayOfWeekHelpers.AddDays(DayOfWeek.Friday, 3);
            Assert.Equal(DayOfWeek.Monday, result);
        }

        [Fact]
        public void GetDaySequenceCarryIntoNextWeekTest()
        {
            var result = DayOfWeekHelpers.GetDaySequence(DayOfWeek.Friday, 5);

            Assert.Collection(result,
                day => Assert.Equal(DayOfWeek.Friday, day),
                day => Assert.Equal(DayOfWeek.Saturday, day),
                day => Assert.Equal(DayOfWeek.Sunday, day),
                day => Assert.Equal(DayOfWeek.Monday, day),
                day => Assert.Equal(DayOfWeek.Tuesday, day)
           );
        }

        [Fact]
        public void NextDateTimeTest()
        {
            var result = DayOfWeekHelpers.Next(DayOfWeek.Monday);
            Assert.Equal(DayOfWeek.Monday, result.DayOfWeek);
            Assert.True(result.Ticks - DateTime.Now.Ticks < TimeSpan.TicksPerDay * DayOfWeekHelpers.NumberOfDaysInAWeek);
        }

        [Fact]
        public void FastToStringTest()
        {
            var result = DayOfWeekHelpers.FastToString(DayOfWeek.Wednesday);
            Assert.Equal("Wednesday", result);
        }
    }
}
