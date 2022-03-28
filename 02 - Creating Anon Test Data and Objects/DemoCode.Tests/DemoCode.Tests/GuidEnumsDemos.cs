using System;
using Xunit;
using AutoFixture;

namespace DemoCode.Tests
{
    public class GuidEnumsDemos
    {
        [Fact]
        public void Guid()
        {
            var fixture = new Fixture();
            var sut = new EmailMessage(fixture.Create<string>(),
                                       fixture.Create<string>(),
                                       fixture.Create<bool>());

            sut.Id = fixture.Create<Guid>();
        }

        [Fact]
        public void Enum()
        {
            var fixture = new Fixture();
            var sut = new EmailMessage(fixture.Create<string>(),
                                       fixture.Create<string>(),
                                       fixture.Create<bool>());

            sut.Id = fixture.Create<Guid>();

            // Loops through each part of the enum 
            sut.MessageType = fixture.Create<EmailMessageType>();
        }
    }
}
