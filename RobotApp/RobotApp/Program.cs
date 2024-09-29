using RobotApp.Classes;

string input = string.Empty;
string[]? inputStart = null;
string[]? inputBoard = null;
string[]? inputMove = null;
Board board = null!;
Robot robot = null!;

//Setup Board
while (board == null)
{
    try
    {
        Console.WriteLine("Enter board Height and depth (5 5):");

        input = Console.ReadLine()!;
        inputBoard = input.Split(' ');

        board = new Board(Convert.ToInt32(inputBoard[0]), Convert.ToInt32(inputBoard[1]));
    }
    catch(Exception ex)
    { 
        board = null!;
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

    }
    catch (Exception ex)
    {
        robot = null!;
        Console.WriteLine(ex.Message + " please try again");
    }
}

while (inputMove == null)
{
    try
    {
        Console.WriteLine("Enter move (RFRFFRFRF)");
    
        input = Console.ReadLine()!;
        inputMove = new string[input.Length];
        inputMove = new string[inputMove.Length];

        for (int i = 0; i < inputMove.Length; i++)
        {
            inputMove[i] = input[i].ToString();
        }
        robot.UserMove = inputMove;
    }
    catch (Exception ex)
    {
        inputMove = null;
        Console.WriteLine(ex.Message + " please try again");
    }
}
robot.DoMove();
if (!(robot.PositionX <= board.Height && robot.PositionX >= 0 && robot.PositionY <= board.Depth && robot.PositionY >= 0))
    Console.WriteLine("Report: Out of bounds");
else
    Console.WriteLine($"Report: {robot.PositionX} {robot.PositionY} {robot.Facing}");