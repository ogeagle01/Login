//Base for user login


System.IO.Directory.CreateDirectory(Auth.foldername); //Creates directory
if (!System.IO.File.Exists(Auth.fileName)) //Creates file if it does not exsist
{
    File.Create(Auth.fileName);
}


Console.WriteLine("Are you a returning user? Y or N"); //Prompts user to type
string userType = Console.ReadLine(); //User types y (yes), for returning user, or n (no), for new user
userType = userType.ToLower(); //Lowers case to make all answers uniform

if (userType == "y") //Allows a returning user to login
{
    if (Auth.authChk()) //Logins user with correct creds
    {
        Console.WriteLine("Welcome!");
        Console.WriteLine("Press Enter to Close");
        Console.ReadLine();
        return;
    }
    else
    {
        Console.WriteLine("Wrong Login!");
        Console.WriteLine("Press Enter to Close");
        Console.ReadLine();
        return;
    }
}


if (userType == "n") //Allows a new user to create an account
{
    if (NewUser.userCreation())
    {
        Console.WriteLine("ReLogin");
        Console.WriteLine("Press Enter to Close");
        Console.ReadLine();
        return;
    }
    else
    {
        Console.WriteLine("Click enter to close");
        Console.ReadLine();
    }
}
