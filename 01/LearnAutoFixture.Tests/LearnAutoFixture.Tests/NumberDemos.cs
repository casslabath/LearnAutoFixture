using System;
using Xunit;

namespace LearnAutoFixture.Tests
{
    public class NumberDemos
    {
        [Fact]
        public void Ints()
        {
            // arange
            var sut = new IntCalculator(); //sut is System Under Test

            // act
            sut.Subtract(1);

            // assert
            Assert.True(sut.Value < 0);
        }
    }
}
