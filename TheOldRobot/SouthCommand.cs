namespace TheOldRobot;

public class SouthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            robot.Y += 1;
        }
        
    }
}