namespace TheOldRobot;

public interface IRobotCommand
{
    void Run(Robot robot);
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