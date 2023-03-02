using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        //[Fact]
        //public void Test1()
        //{

        //}
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("rotator", true)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            //arange
            var test = new WordSmith();
            //act
            bool actual = test.IsAPalindrome(word);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
