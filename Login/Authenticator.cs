//Authenticates creditials 
public static class Auth
{
    public static string userCredPath = @"C:\Users\micha\Documents\Login\userCreds.txt"; //(file for user creds)
    public static bool authChk()
    {
        List<string> lines = new List<string>();
        lines = File.ReadAllLines(userCredPath).ToList();

        Console.WriteLine("Username:");
        string userName = Console.ReadLine();

        Console.WriteLine("Password:");
        string passWord = Console.ReadLine();

        

        bool auth = lines.Contains($"{userName},{Encrypt.EncryptPassword(passWord)}");

        if (auth)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}