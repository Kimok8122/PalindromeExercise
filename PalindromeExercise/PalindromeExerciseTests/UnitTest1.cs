using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("GoodDay", false)]
        [InlineData("madam", true)]
        [InlineData("Kimo",false)]

        public void PalindromeTester(string word, bool expected)

        {
            var wordSmith = new WordSmith();

            var wordActual = wordSmith.IsAPalindrome(word);

            Assert.Equal(expected, wordActual);

        }
    }
}
