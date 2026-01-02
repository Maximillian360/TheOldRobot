namespace TheOldRobot;

public abstract class RobotCommand
{
    public abstract void Run(Robot robot);
}

public enum RobotCommandType
{
    on,
    off,
    north,
    east,
    south,
    west,
}