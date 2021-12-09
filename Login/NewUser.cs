//Creates new user
public class NewUser
{
    public static bool userCreation()
    {
        List<string> lines = new List<string>();
        lines = File.ReadAllLines(Auth.userCredPath).ToList();
        Console.WriteLine("What is your username?");
        string userName = Console.ReadLine();

        Console.WriteLine("What is your password?");
        string passWord = Console.ReadLine();

        Console.WriteLine("Comfirm Password");
        string passChk = Console.ReadLine();

        if (passChk == passWord)
        {
            Console.WriteLine("Account has been created!");
            lines.Add($"{userName},{Encrypt.EncryptPassword(passWord)}");
            File.WriteAllLines(Auth.userCredPath, lines);
            return true;
        }
        else
        {
            Console.WriteLine("Incorrect Password!");
            return false;


        }

        
    }
}