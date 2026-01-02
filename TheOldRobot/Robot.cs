namespace TheOldRobot;

public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public RobotCommand?[] Commands { get; } = new RobotCommand?[3];

    public Robot(RobotCommand?[] commands = null, int? x = 0, int y = 0, bool isPowered = false)
    {
        Commands[0] = null;
    }

    public void Run()
    {
        foreach (RobotCommand? command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }

    public void PopulateCommands(RobotCommand?[] commands)
    {
        for (int i = 0; i < commands.Length; i++)
        {
            Commands[i] = commands[i];
        }
    }
}