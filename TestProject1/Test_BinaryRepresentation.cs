using System;
using static ClassLibrary1.BinaryRepresentation;
using Xunit;
namespace TestProject1
{
    public class Test_BinaryRepresentation
    {
        [Theory]
        [InlineData("1101", 6)]
        [InlineData("10", 1)]
        public void Test_NumSteps(string s, int expectedResult)
        {
            Assert.Equal(NumSteps(s), expectedResult);
        }
    }
}
