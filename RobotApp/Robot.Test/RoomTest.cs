
using RobotApp.Classes;

namespace Robot.Test
{
    public class RoomTest
    {
        [Fact]
        public void Check_Room_isnotNull()
        {
            Room? room = null;
            try
            {
                room = new Room();
            }
            catch {}
            Assert.NotNull(room);
        }
    }
}
