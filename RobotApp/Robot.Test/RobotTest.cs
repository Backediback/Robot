namespace Robot.Test
{
    public class RobotTest
    {
        [Fact]
        public void Move_Right_From_North_To_East()
        {
            //Arrange
            RobotApp.Classes.Robot robot = new RobotApp.Classes.Robot(9, 9, "N");
            robot.UserMove = ["R"]; ;
            //Act
            robot.DoMove();
            //Assert
            Assert.True(robot.Facing == "E");
        }

        [Fact]
        public void Move_Out_Of_Board()
        {
            //Arrange
            RobotApp.Classes.Board board = new RobotApp.Classes.Board(5, 5);
            RobotApp.Classes.Robot robot = new RobotApp.Classes.Robot(0,0, "N");
            robot.UserMove = ["F"];
            //Act
            robot.DoMove();
            bool inBound = robot.PositionX <= board.Height && robot.PositionX >= 0 && robot.PositionY <= board.Depth && robot.PositionY >= 0;
            //Assert
            Assert.False(inBound);
        }

        [Fact]
        public void Move_Not_Out_Of_Board()
        {
            //Arrange
            RobotApp.Classes.Board board = new RobotApp.Classes.Board(5, 5);
            RobotApp.Classes.Robot robot = new RobotApp.Classes.Robot(0, 0, "N");
            robot.UserMove = ["RRFF"];
            //Act
            robot.DoMove();
            bool inBound = robot.PositionX <= board.Height && robot.PositionX >= 0 && robot.PositionY <= board.Depth && robot.PositionY >= 0;
            //Assert
            Assert.True(inBound);
        }
    }
}