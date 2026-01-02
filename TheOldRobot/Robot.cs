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
    
    public void PopulateCommands(RobotCommand[] initialCommands)
    {
        for (int i = 0; i < initialCommands.Length; i++)
        {
            Commands[i] = initialCommands[i];
        }
    }

    public RobotCommand CommandFactory(RobotCommandType command)
    {
        RobotCommand resultCommand = command switch
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