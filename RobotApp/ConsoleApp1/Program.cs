using RobotApp.Classes;

string input = string.Empty;
string[] inputStart = null;
string[] inputMove = null;
Board board = null;
Robot robot = null;

while(board == null)
{ 
    Console.WriteLine("Enter board Height and depth:");

    input = Console.ReadLine();
    try
    { 
        inputStart = input.Split(' ');

        board = new Board(Convert.ToInt32(inputStart[0]), Convert.ToInt32(inputStart[1]));
    }
    catch(Exception ex)
    { 
        board = null;
        Console.WriteLine(ex.Message); 
    }
}

while (robot == null)
{
    Console.WriteLine("Enter start x, start y and direction (3 3 N)");
    try
    {
        input = Console.ReadLine();
        inputMove = input.Split(' ');
        robot = new Robot(Convert.ToInt32(inputMove[0]), Convert.ToInt32(inputMove[1]), inputMove[2]);

    }
    catch (Exception ex)
    {
        robot = null;
        Console.WriteLine(ex.Message);
    }

    try
    {

    }
    catch (Exception ex)
    {

    }
}

