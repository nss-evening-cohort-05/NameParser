using System;
using NameParser.App;
using Xunit;

namespace NameParser.Tests
{
    public class WhenParsingNameInformation
    {
        [Fact]
        public void OneNameIsEnteredFirstNameIsPopulated()
        {
            //Arrange
            var name = "Zendaya";
            var nameParser = new Parser();
            //Act
            var result = nameParser.ParseName(name);
            //Assert
            Assert.Equal(result.FirstName,"Zendaya");
        }

        [Theory]
        [InlineData("Steve Jones","Steve","Jones")]
        [InlineData("Mary Barnes-Jones","Mary","Barnes-Jones")]
        [InlineData("Nathan Barnes-Jones","Nathan","Barnes-Jones")]
        public void TwoNamesAreEnteredFirstAndLastNameArePopulated(string nameToTest, string expectedFirstName,string expectedLastName) 
        {
            //Arrange
            var nameParser = new Parser();
            //Act
            var result = nameParser.ParseName(nameToTest);
            //Assert
            Assert.Equal(result.FirstName, expectedFirstName);
            Assert.Equal(result.LastName, expectedLastName);
        }
    }
}
