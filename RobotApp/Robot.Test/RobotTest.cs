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
        public void Move_Out_Of_Room()
        {
            //Arrange
            RobotApp.Classes.Room room = new RobotApp.Classes.Room(5, 5);
            RobotApp.Classes.Robot robot = new RobotApp.Classes.Robot(0, 0, "N");
            robot.UserMove = ["F"];
            //Act
            robot.DoMove();
            bool inBound = robot.PositionX <= room.Height && robot.PositionX >= 0 && robot.PositionY <= room.Depth && robot.PositionY >= 0;
            //Assert
            Assert.False(inBound);
        }

        [Fact]
        public void Move_Not_Out_Of_Room()
        {
            //Arrange
            RobotApp.Classes.Room room = new RobotApp.Classes.Room(5, 5);
            RobotApp.Classes.Robot robot = new RobotApp.Classes.Robot(0, 0, "N");
            robot.UserMove = ["RRFF"];
            //Act
            robot.DoMove();
            bool inBound = robot.PositionX <= room.Height && robot.PositionX >= 0 && robot.PositionY <= room.Depth && robot.PositionY >= 0;
            //Assert
            Assert.True(inBound);
        }

        [Fact]
        public void Test_Output_From_UseCase1()
        {
            RobotApp.Classes.Room room = new RobotApp.Classes.Room(5, 5);
            RobotApp.Classes.Robot robot = new RobotApp.Classes.Robot(1, 2, "N");
            string input = "RFRFFRFRF";
            robot.UserMove = robot.splitMove(input);
            //Act
            robot.DoMove();
            var report = $"{robot.PositionX} {robot.PositionY} {robot.Facing}";
            Assert.Equal("1 3 N", report);
        }
        [Fact]
        public void Test_Output_From_UseCase2()
        {
            RobotApp.Classes.Room room = new RobotApp.Classes.Room(5, 5);
            RobotApp.Classes.Robot robot = new RobotApp.Classes.Robot(0, 0, "E");
            string input = "RFLFFLRF";
            
            robot.UserMove = robot.splitMove(input);

            //Act
            robot.DoMove();
            var report = $"{robot.PositionX} {robot.PositionY} {robot.Facing}";
            Assert.Equal("3 1 E", report);
        }
    }
}