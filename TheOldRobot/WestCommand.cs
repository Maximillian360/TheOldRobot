namespace TheOldRobot;

public class WestCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            robot.X -= 1;
        }
    }
}