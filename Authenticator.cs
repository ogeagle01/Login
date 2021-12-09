//Authenticates creditials 


public static class Auth
{
    //public static string filename = @"C:\UserCreds\userCreds.txt"; 
       public static string foldername = @"C:\UserCreds"; //Folder for the userCreds.text file
    public static string fileName = @"C:\UserCreds\userCreds.txt"; //file to store user creds


    public static bool authChk()
    {
        List<string> lines = new List<string>();
        lines = File.ReadAllLines(fileName).ToList();


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