﻿using System;
using Xunit;
using AutoFixture;

namespace DemoCode.Tests
{
    public class NumberDemos
    {
        [Fact]
        public void Ints()
        {
            // arrange
            var sut = new IntCalculator();
            Fixture fixture = new Fixture();

            // act
            sut.Subtract(fixture.Create<int>());

            // assert
            Assert.True(sut.Value < 0);
        }

        [Fact]
        public void Decimals()
        {
            // arrange
            var sut = new DecimalCalculator();
            var fixture = new Fixture();

            decimal num = fixture.Create<decimal>();

            // act
            sut.Add(num);

            // assert
            Assert.Equal(num, sut.Value);
        }
    }
}
