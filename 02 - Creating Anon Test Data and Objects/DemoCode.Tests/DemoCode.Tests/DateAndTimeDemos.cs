using System;
using Xunit;
using AutoFixture;

namespace DemoCode.Tests
{
    public class DateAndTimeDemos
    {
        [Fact]
        public void DateTimes()
        {
            var fixture = new Fixture();
            // DateTime logTime = new DateTime(2020, 1, 21);
            DateTime logTime = fixture.Create<DateTime>();

            LogMessage result = LogMessageCreator.Create(fixture.Create<string>(), logTime);

            Assert.Equal(logTime.Year, result.Year);
        }

        [Fact]
        public void TimeSpans()
        {
            var fixture = new Fixture();
            TimeSpan timeSpan = fixture.Create<TimeSpan>();
            // breakpoint to see generated value
            // mine was {00:00:00.0000131}
        }
    }
}
