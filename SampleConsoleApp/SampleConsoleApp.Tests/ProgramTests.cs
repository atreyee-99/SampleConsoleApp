using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;
using SampleConsoleApp;

namespace SampleConsoleApp.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData(2, true)]   // Positive even number
        [InlineData(3, false)]  // Positive odd number
        [InlineData(0, true)]   // Zero (considered even)
        [InlineData(-4, true)]  // Negative even number
        [InlineData(-5, false)] // Negative odd number
        public void IsEven_ShouldReturnCorrectResult(int number, bool expected)
        {
            // Act
            bool result = Program.IsEven(number);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void IsEven_LargeEvenNumber_ReturnsTrue()
        {
            // Arrange
            int largeEvenNumber = 1000000;

            // Act
            bool result = Program.IsEven(largeEvenNumber);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsEven_LargeOddNumber_ReturnsFalse()
        {
            // Arrange
            int largeOddNumber = 1000001;

            // Act
            bool result = Program.IsEven(largeOddNumber);

            // Assert
            Assert.False(result);
        }
    }
}