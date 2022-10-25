PasswordValidator validator = new PasswordValidator();

string password = "";

while (password != "exit")
{
    Console.WriteLine("Enter a password, or type exit to end: ");
    password = Console.ReadLine();
    if (password == null)
    {
        break;
    }
    if (validator.PasswordValid(password))
    {
        Console.WriteLine("Valid Password!");
    }
    else
    {
        Console.WriteLine("Invalid Password");
    }
}

public class PasswordValidator
{
    public bool PasswordValid(string password)
    {
        if (password.Length < 6)
        {
            return false;
        }
        if (password.Length > 13)
        {
            return false;
        }
        if (!hasUpperCase(password))
        {
            return false;
        }
        if (!hasLowerCase(password))
        {
            return false;
        }
        if (!hasNumber(password))
        {
            return false;
        }
        if (password.Contains("T"))
        {
            return false;
        }
        if (password.Contains("&"))
        {
            return false;
        }

        return true;
    }
    public bool hasUpperCase(string password)
    {
        foreach (char c in password)
        {
            if (char.IsUpper(c))
            {
                return true;
            }
        }
        return false;
    }
    public bool hasLowerCase(string password)
    {
        foreach (char c in password)
        {
            if (char.IsLower(c))
            {
                return true;
            }
        }
        return false;
    }
    public bool hasNumber(string password)
    {
        foreach (char c in password)
        {
            if (char.IsDigit(c))
            {
                return true;
            }
        }
        return false;
    }
}