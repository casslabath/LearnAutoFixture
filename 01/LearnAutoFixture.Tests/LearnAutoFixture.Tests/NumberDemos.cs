using System;
using Xunit;
using AutoFixture;

namespace LearnAutoFixture.Tests
{
    public class NumberDemos
    {
        [Fact]
        public void Ints()
        {
            // arange
            var sut = new IntCalculator(); //sut is System Under Test
            var fixture = new Fixture();
                
            // act
            sut.Subtract(fixture.Create<int>());

            // assert
            Assert.True(sut.Value < 0);
        }
    }
}
