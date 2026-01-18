namespace TheOldRobot;

public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public IRobotCommand?[] Commands { get; } = new IRobotCommand?[3];

    public Robot(IRobotCommand?[] commands = null, int? x = 0, int y = 0, bool isPowered = false)
    {
        Commands[0] = null;
    }

    public void Run()
    {
        foreach (IRobotCommand? command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
    
    public void PopulateCommands(IRobotCommand[] initialCommands)
    {
        for (int i = 0; i < initialCommands.Length; i++)
        {
            Commands[i] = initialCommands[i];
        }
    }

    public IRobotCommand CommandFactory(RobotCommandType command)
    {
        IRobotCommand resultCommand = command switch
        {
            RobotCommandType.on => new OnCommand(),
            RobotCommandType.off => new OffCommand(),
            RobotCommandType.north => new NorthCommand(),
            RobotCommandType.south => new SouthCommand(),
            RobotCommandType.east => new EastCommand(),
            RobotCommandType.west => new WestCommand(),
            _ => new OffCommand()

        };
        return resultCommand; 
    }
}