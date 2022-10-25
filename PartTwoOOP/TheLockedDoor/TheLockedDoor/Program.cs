Console.Write("Please enter the initial passcode for the door: ");
int firstPasscode = Convert.ToInt32(Console.ReadLine());
Door door = new Door(firstPasscode);
int input;

do
{
    Console.WriteLine($"Now the door is {door.State}. Enter the corresponding number to interact with the door.\n" +
    "1 - Open\n2 - Close\n3 - Lock\n4 - Unlock\n5 - Change Passcode\n6 - Leave Door");
    input = Convert.ToInt32(Console.ReadLine());
    switch (input)
    {
        case 1:
            door.Open();
            break;
        case 2:
            door.Close();
            break;
        case 3:
            door.Lock();
            break;
        case 4:
            Console.Write("What is the passcode? ");
            int attempt = Convert.ToInt32(Console.ReadLine());
            door.Unlock(attempt);
            break;
        case 5:
            Console.Write("What is the current passcode? ");
            int currentPasscode = Convert.ToInt32(Console.ReadLine());
            Console.Write("What do you want the new passcode to be? ");
            int newPasscode = Convert.ToInt32(Console.ReadLine());
            door.ChangePassword(currentPasscode, newPasscode);
            break;
    }
}
while (input != 6);



public class Door
{
    public DoorState State { get; set; }
    public int Passcode { get; set; }

    public Door(int firstPasscode)
    {
        State = DoorState.Closed;
        Passcode = firstPasscode;
    }

    public void Open()
    {
        if(State == DoorState.Closed)
        {
            State = DoorState.Open;
        }
        else if(State == DoorState.Locked)
        {
            Console.WriteLine("Door is locked, unlock with passcode first.");
            State = DoorState.Locked;
        }
        else
        {
            State = DoorState.Open;
        }
    }
    public void Close()
    {
        if(State == DoorState.Open)
        {
            State = DoorState.Closed;
        }
        else if(State == DoorState.Locked)
        {
            State = DoorState.Locked;
        }
        else
        {
            State = DoorState.Closed;
        }
    }
    public void Lock()
    {
        if (State == DoorState.Open)
        {
            State = DoorState.Locked;
        }
        else if (State == DoorState.Closed)
        {
            State = DoorState.Locked;
        }
        else
        {
            State = DoorState.Closed;
        }
    }
    public void Unlock(int input)
    {
        if(State == DoorState.Locked && input == Passcode)
        {
            State = DoorState.Closed;
        }
        else if(State == DoorState.Open)
        {
            State = DoorState.Open;
        }
        else
        {
            State = DoorState.Locked;
        }
    }
    public int ChangePassword(int passcode, int newPasscode)
    {
        if (Passcode == passcode)
        {
            return newPasscode;
        } 
        return Passcode;
    }
}
public enum DoorState { Locked, Open, Closed}