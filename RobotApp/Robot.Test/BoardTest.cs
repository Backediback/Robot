
using RobotApp.Classes;

namespace Robot.Test
{
    public class BoardTest
    {
        [Fact]
        public void Check_Board_isnotNull()
        {
            Board? board = null;
            try
            {
                board = new Board();
            }
            catch {}
            Assert.NotNull(board);
        }
    }
}
