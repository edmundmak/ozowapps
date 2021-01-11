using System;
using Xunit;

using Autofac.Extras.Moq;
using Sorting;

namespace SortStringTest
{
    public class SortedListLettersUsingBuiltTest
    {
       
        [Theory]
        [InlineData("Contrary to popular belief, the pink unicorn flies east")]
        public void SortedListLettersUsingBuiltIn_Success(string inputString)
        {
            using (var mock = AutoMock.GetLoose())
            {
                var getSortedString = mock.Create<GetSorting>();
                var actual = getSortedString.SortedListLettersUsingBuiltIn(inputString);
                Assert.NotNull(actual);
            }
        }
        [Theory]
        [InlineData("")]
        public void SortedListLettersUsingBuiltIn_Failure(string inputString)
        {
            using (var mock = AutoMock.GetLoose())
            {
                var getSortedString = mock.Create<GetSorting>();
                var actual = getSortedString.SortedListLettersUsingBuiltIn(inputString);
                Assert.Empty(actual);
            }
        }
    }
}
