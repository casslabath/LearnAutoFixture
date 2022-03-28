using System;
using Xunit;
using AutoFixture;
using System.Collections.Generic;

namespace DemoCode.Tests
{
    public class SequencesDemos
    {
        [Fact]
        public void SequenceofStrings()
        {
            var fixture = new Fixture();

            IEnumerable<string> messages = fixture.CreateMany<string>();

            // debuged and looked at messages
            // I had three anon strings in my messages
        }

        [Fact]
        public void ExplicitNumberOfItems()
        {
            var fixture = new Fixture();

            IEnumerable<int> messages = fixture.CreateMany<int>(6);
        }


        [Fact]
        public void AddingToExistingList()
        {
            var fixture = new Fixture();
            var sut = new DebugMessageBuffer();

            fixture.AddManyTo(sut.Messages, 10);

            sut.WriteMessages();

            Assert.Equal(10, sut.MessagesWritten);
        }
    }
}
