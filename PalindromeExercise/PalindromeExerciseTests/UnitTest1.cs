using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("palindrome", false)]
        [InlineData("rotator", true)]
        [InlineData("demon", false)]
        [InlineData("supercalifragilisticexpialidocious", false)]
        public void IsAPalindroneTest(string word, bool expected)
        {
            // Arrange
            var WordSmith = new WordSmith();
            // Act
            var actual = WordSmith.IsAPalindrone(word);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
