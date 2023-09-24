namespace TicTacToe.Tests
{
    public class BoardTests
    {
        [Fact]
        public void X_FirstRow_WinsGame()
        {
            Board board = new Board();

            board.PutMarker(0, Marker.X);
            board.PutMarker(1, Marker.X);
            board.PutMarker(2, Marker.X);

            bool didXWin = board.CheckWinningCondition(Marker.X);
            Assert.True(didXWin);

            bool didYWin = board.CheckWinningCondition(Marker.Y);
            Assert.False(didYWin);
        }

        [Fact]
        public void Y_FirstRow_WinsGame()
        {
            Board board = new Board();

            board.PutMarker(0, Marker.Y);
            board.PutMarker(1, Marker.Y);
            board.PutMarker(2, Marker.Y);

            bool didXWin = board.CheckWinningCondition(Marker.X);
            Assert.False(didXWin);

            bool didYWin = board.CheckWinningCondition(Marker.Y);
            Assert.True(didYWin);
        }

        [Fact]
        public void Neither_Wins()
        {
            Board board = new Board();

            bool didXWin = board.CheckWinningCondition(Marker.X);
            Assert.False(didXWin);

            bool didYWin = board.CheckWinningCondition(Marker.Y);
            Assert.False(didYWin);
        }
    }
}