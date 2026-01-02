namespace TheOldRobot;

public abstract class RobotCommand
{
    public abstract void Run(Robot robot);
}

public enum RobotCommandType
{
    On,
    Off,
    North,
    East,
    South,
    West,
}