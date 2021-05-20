using System;
using static ClassLibrary1.SubstringProcessor;
using Xunit;

namespace TestProject1
{
    public class Test_SubstringProcessor
    {
        [Theory]
        [InlineData("abab", true)]
        [InlineData("aba", false)]
        [InlineData("abcabcabcabc", true)]
        public void Test_RepeatedSubstringPattern(string s, bool expectedResult)
        {
            Assert.Equal(RepeatedSubstringPattern(s), expectedResult);
        }

    }
}