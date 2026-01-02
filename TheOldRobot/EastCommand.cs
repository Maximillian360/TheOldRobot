namespace TheOldRobot;

public class EastCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            robot.X += 1;
        }
    }
}