// See https://aka.ms/new-console-template for more information

using TheOldRobot;

Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to OldRobot!");
Robot robot = new Robot();
int commandLimit = 3;
RobotCommand?[] initialCommands = new RobotCommand?[commandLimit];
while (true)
{
    Console.WriteLine("START");
    for (int i = 0; i < commandLimit; i++)
    {
        bool invalidInput = true;
        while (invalidInput)
        {
            Console.WriteLine($"Enter your command: ");
            var command = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(command))
            {
                Console.WriteLine($"Command is empty!");
                continue;
            }
            command = command.ToLower();

            if (!Enum.TryParse(command, out RobotCommandType checkCommand))
            {
                Console.WriteLine($"Invalid command: {command}!");
                continue;
            }
            
            if (!Enum.IsDefined(typeof(RobotCommandType), checkCommand))
            {
                Console.WriteLine($"Command not defined: {checkCommand}!");
                continue;
            }
            var testCommand = robot.CommandFactory(checkCommand);
            initialCommands[i] = testCommand;
            Console.WriteLine($"{initialCommands[i]}");
            invalidInput = false;
        }
    }
    Console.WriteLine("END");
}