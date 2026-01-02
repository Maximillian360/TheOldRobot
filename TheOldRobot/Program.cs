// See https://aka.ms/new-console-template for more information

using TheOldRobot;

Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to OldRobot!");
// RobotCommand[] robotCommands = new RobotCommand[];
Robot robot = new Robot();

while (true)
{
    for (int i = 0; i < 3; i++)
    {
        bool invalidInput = true;
        while (invalidInput)
            
        {
            Console.WriteLine($"Enter your command: ");
            var command = Console.ReadLine();
            if (command != null)
            {
                command.ToLower();
            }

            if (Enum.TryParse(command, out RobotCommandType checkCommand))
            {
                
            }
        }
        
        
    }
}