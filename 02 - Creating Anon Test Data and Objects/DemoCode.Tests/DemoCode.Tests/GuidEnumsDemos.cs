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
        }
    }
}
