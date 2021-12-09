//Base for user login

Console.WriteLine("Are you a returning user? Y or N"); //Prompts user to type
string userType = Console.ReadLine(); //User types y (yes), for returning user, or n (no), for new user
userType = userType.ToLower(); //Lowers case to make all answers uniform

if (userType == "y") //Allows a returning user to login
{
    if (Auth.authChk()) //Logins user with correct creds
    {
        Console.WriteLine("Welcome!");
    }
    else
    {
        Console.WriteLine("Wrong Login!");
        return;
    }
}

if (userType == "n") //Allows a new user to create an account
{
    if (NewUser.userCreation())
    {
        Console.WriteLine("ReLogin");
        return;
    }
    else
    {
        Console.WriteLine("Try again");
    }
}
