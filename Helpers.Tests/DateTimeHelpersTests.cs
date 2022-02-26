using System;
using Xunit;

namespace Helpers.Tests
{
    public class DateTimeHelpersTests
    {
        private readonly DateTime _yesterday = DateTime.Now.AddDays(-1);
        private readonly DateTime _today = DateTime.Now;
        private readonly DateTime _tomorrow = DateTime.Now.AddDays(1);

        [Fact]
        public void IsBeforeOrOnTest()
        {
            Assert.True(DateTimeHelpers.IsBeforeOrOn(_yesterday, _today));
            
        }

        [Fact]
        public void IsAfterOrOnTest()
        {
            Assert.True(DateTimeHelpers.IsAfterOrOn(_tomorrow, _today));
            
        }

        [Fact]
        public void IsOnTest()
        {
            Assert.True(DateTimeHelpers.IsOn(_today, _today));
            
        }

        [Fact]
        public void IsNotOnSameDayAsTest()
        {
            Assert.True(DateTimeHelpers.IsNotOnSameDayAs(_yesterday, _tomorrow));
            
        }

        [Fact]
        public void IsTodayTest()
        {
            Assert.True(DateTimeHelpers.IsToday(_today));
        }

        [Fact]
        public void IsTomorrowTest()
        {
            Assert.True(DateTimeHelpers.IsTomorrow(_tomorrow));
        }

        [Fact]
        public void IsYesterdayTest()
        {
            Assert.True(DateTimeHelpers.IsYesterday(_yesterday));
        }

        [Fact]
        public void IsBeforeTest()
        {
            Assert.True(DateTimeHelpers.IsBefore(_yesterday, _today));
        }

        [Fact]
        public void IsAfterTest()
        {
            Assert.True(DateTimeHelpers.IsAfter(_tomorrow, _today));
        }

        [Fact]
        public void IsBetweenTest()
        {
            Assert.True(DateTimeHelpers.IsBetween(_today, _yesterday, _tomorrow));
            Assert.True(DateTimeHelpers.IsBetween(_today, _tomorrow, _yesterday));
        }

        [Fact]
        public void IsNotBetweenTest()
        {
            Assert.True(DateTimeHelpers.IsNotBetween(_tomorrow, _today, _yesterday));
        }

        [Fact]
        public void IsDefaultTest()
        {
            Assert.False(DateTimeHelpers.IsDefault(_today));
            Assert.True(DateTimeHelpers.IsDefault(default(DateTime)));
        }
    }
}
