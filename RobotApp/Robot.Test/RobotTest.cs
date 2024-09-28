using Newtonsoft.Json.Linq;
using RobotApp.Classes;
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
            RobotApp.Classes.Robot robot = new RobotApp.Classes.Robot(0,0, "N");
            robot.UserMove = ["F"]; ;
            //Act
            robot.DoMove();
            //Assert
            Assert.True(robot.PositionY == -1);
        }
    }
}