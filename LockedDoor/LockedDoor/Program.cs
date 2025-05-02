using LockedDoor;

Console.Write("Set the initial passcode for the door: ");
if (!int.TryParse(Console.ReadLine(), out int initialPasscode) || initialPasscode <= 0)
{
    Console.WriteLine("Invalid passcode. Please restart the application.");
}

Door door = new Door(initialPasscode);

while (true)
{
    Console.WriteLine("\nCommands: open, close, lock, unlock, change_passcode, status, exit");
    Console.Write("Enter your command: ");
    string command = Console.ReadLine()?.Trim().ToLower();

    switch (command)
    {
        case "open":
            door.Open();
            break;
        case "close":
            door.Close();
            break;
        case "lock":
            door.Lock();
            break;
        case "unlock":
            Console.Write("Enter passcode to unlock: ");
            if (int.TryParse(Console.ReadLine(), out int unlockCode))
            {
                door.Unlock(unlockCode);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric passcode.");
            }
            break;
        case "change_passcode":
            Console.Write("Enter current passcode: ");
            if (!int.TryParse(Console.ReadLine(), out int currentCode))
            {
                Console.WriteLine("Invalid input. Please enter a numeric passcode.");
                break;
            }

            Console.Write("Enter new passcode: ");
            if (!int.TryParse(Console.ReadLine(), out int newCode))
            {
                Console.WriteLine("Invalid input. Please enter a numeric passcode.");
                break;
            }

            door.ChangePasscode(currentCode, newCode);
            break;
        case "status":
            door.DisplayStatus();
            break;
        case "exit":
            Console.WriteLine("Exiting the program.");
            return;
        default:
            Console.WriteLine("Invalid command. Please try again.");
            break;
    }
}
