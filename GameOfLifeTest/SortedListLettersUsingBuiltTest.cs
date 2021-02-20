using System;
using Xunit;

using Autofac.Extras.Moq;
using gameoflife;

namespace GameofLifeTest
{
    public class GameofLifeTest
    {
       
        [Theory]
        [InlineData(1,10)]
        public void GameofLife_Success(int rows, int columns)
        {
            using (var mock = AutoMock.GetLoose())
            {
                var game = mock.Create<Game>();
                game.PlayGame(rows,columns);
                Assert.NotNull(game.OutputGrid);
            }
        }
        [Theory]
        [InlineData(0, 0)]
        public void GameofLife_Failure(int rows, int columns)
        {
            using (var mock = AutoMock.GetLoose())
            {
                var game = mock.Create<Game>();
               
                Exception exception = null;
                try
                {
                    game.PlayGame(rows, columns);
                }
                catch (Exception ex)
                {
                    exception = ex;
                }
                Assert.NotNull(exception);
            }
        }
    }
}
