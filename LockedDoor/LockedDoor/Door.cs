namespace LockedDoor;

public class Door
{
    private bool _isOpen;
    private bool _isLocked;
    private int _passcode;

    public Door(int initialPasscode)
    {
        if (initialPasscode <= 0)
            throw new ArgumentException("Passcode must be a positive integer.");

        _passcode = initialPasscode;
        _isOpen = false;
        _isLocked = false;

    }

    public void Open()
    {
        if (_isLocked)
        {
            Console.WriteLine("Cannot open a locked door. Please unlock it first.");
            return;
        }

        if (_isOpen)
        {
            Console.WriteLine("The door is already open.");
        }
        else
        {
            _isOpen = true;
            Console.WriteLine("The door is now open.");
        }
    }

    public void Close()
    {
        if (!_isOpen)
        {
            Console.WriteLine("The door is already closed.");
        }
        else
        {
            _isOpen = false;
            Console.WriteLine("The door is now closed.");
        }
    }

    public void Lock()
    {
        if (_isOpen)
        {
            Console.WriteLine("Cannot lock an open door. Please close it first.");
            return;
        }

        if (_isLocked)
        {
            Console.WriteLine("The door is already locked.");
        }
        else
        {
            _isLocked = true;
            Console.WriteLine("The door is now locked.");
        }
    }

    public void Unlock(int code)
    {
        if (!_isLocked)
        {
            Console.WriteLine("The door is already unlocked.");
            return;
        }

        if (code == _passcode)
        {
            _isLocked = false;
            Console.WriteLine("The door is now unlocked.");
        }
        else
        {
            Console.WriteLine("Incorrect passcode. The door remains locked.");
        }
    }

    public void ChangePasscode(int currentCode, int newCode)
    {
        if (newCode <= 0)
        {
            Console.WriteLine("New passcode must be a positive integer.");
            return;
        }

        if (currentCode == _passcode)
        {
            _passcode = newCode;
            Console.WriteLine("Passcode successfully changed.");
        }
        else
        {
            Console.WriteLine("Incorrect current passcode. Passcode was not changed.");
        }
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Door Status: {(_isOpen ? "Open" : "Closed")}, {(_isLocked ? "Locked" : "Unlocked")}");
    }
}
