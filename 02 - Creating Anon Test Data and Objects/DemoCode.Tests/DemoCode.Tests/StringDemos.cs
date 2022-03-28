using Xunit;
using AutoFixture;

namespace DemoCode.Tests
{
    public class StringDemos
    {
        [Fact]
        public void BasicStirngs()
        {
            // arrange
            var fixture = new Fixture();
            var sut = new NameJoiner();

            /*
             * Learned through debug that the default string 
             * created by fixture is a GUID
             */
            //var firstName = fixture.Create<string>();
            //var lastName = fixture.Create<string>();

            /*
             * Giving a seeded string can make debugging much 
             * easier
             */
            var firstName = fixture.Create("First_");
            var lastName = fixture.Create("Last_");

            // act
            var result = sut.Join(firstName, lastName);

            // assert
            Assert.Equal(firstName + " " + lastName, result);
        }

        [Fact]
        public void Chars()
        {
            var fixture = new Fixture();

            /*
             * debugged to look at generated value 
             * Mine was '\0'
             */
            var anonChar = fixture.Create<char>();
        }
    }
}
