using RobotApp.Classes;

string input = string.Empty;
string[]? inputStart = null;
string[]? inputRoom = null;
Room room = null!;
Robot robot = null!;

//Setup room
while (room == null)
{
    try
    {
        Console.WriteLine("Enter room Height and depth (5 5):");

        input = Console.ReadLine()!;
        inputRoom = input.Split(' ');

        room = new Room(Convert.ToInt32(inputRoom[0]), Convert.ToInt32(inputRoom[1]));
    }
    catch(Exception ex)
    { 
        room = null!;
        Console.WriteLine(ex.Message + " please try again"); 
    }
}
//Setup Robot
while (robot == null)
{
    try
{    
        Console.WriteLine("Enter start x, start y and direction (3 3 N)");
        input = Console.ReadLine()!;
        inputStart = input.Split(' ');
        robot = new Robot(Convert.ToInt32(inputStart[0]), Convert.ToInt32(inputStart[1]), inputStart[2].ToUpper());
        if (!(robot.PositionX <= room.Height && robot.PositionX >= 0 && robot.PositionY <= room.Depth && robot.PositionY >= 0))
            throw new Exception("The start is out of bounds");
    }
    catch (Exception ex)
    {
        robot = null!;
        Console.WriteLine(ex.Message + " please try again");
    }
}

while (robot.UserMove == null)
{
    try
    {
        Console.WriteLine("Enter move (RFRFFRFRF)");
    
        input = Console.ReadLine()!;

        robot.UserMove = robot.splitMove(input);
    }
    catch (Exception ex)
    {
        robot.UserMove = null;
        Console.WriteLine(ex.Message + " please try again");
    }
}
robot.DoMove();
if (!(robot.PositionX <= room.Height && robot.PositionX >= 0 && robot.PositionY <= room.Depth && robot.PositionY >= 0))
    Console.WriteLine($"Report: Out of bounds, the room is {room.Height} by {room.Depth}");
    Console.WriteLine($"Report: {robot.PositionX} {robot.PositionY} {robot.Facing}");