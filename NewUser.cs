//Creates new user


public class NewUser
{


    public static bool userCreation()
    {


        List<string> lines = new List<string>();
        lines = File.ReadAllLines(Auth.fileName).ToList();


        Console.WriteLine("What is your username?");
        string userName = Console.ReadLine();


        Console.WriteLine("What is your password?");

        
        string passWord = Console.ReadLine();


        Console.WriteLine("Comfirm Password");
        string passChk = Console.ReadLine();


        List<char> sC = new List<char>(){'~', ':', '+', '[', '@', '^', '{', '%', '(', '-', '"', '*', '|', ',', '&', '<', '`', '}', '.', '_', '=', ']', '!', '>', ';', '?', '#', '$', ')', '/'};
        bool check = sC.Any(t => passWord.Contains(t));
        bool capCheck = passWord.Any(c => char.IsUpper(c));


        if (passChk == passWord)
        {
            while (userName.Length < 1)
            {
                Console.WriteLine("Username too short! Choose Another!");
                userName = Console.ReadLine();
            }

            if (passWord.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters. Please try again!");

                return false;
            }

            if (capCheck == false)
            {
                Console.WriteLine("Password does not caontain any capital letters. Please try again!");

                return false;
            }

            while (check == false)
            {
                Console.WriteLine("Password does not contain any speical characters! Please try again!");

                return false;
            }

            foreach (string i in lines)
            {
                while (i.Contains(userName))
                {
                Console.WriteLine("Username taken. Please choose another!");
                Console.WriteLine("What is your username?");
                userName = Console.ReadLine();
                 }
            }

            Console.WriteLine("Account has been created!");
            lines.Add($"{userName},{Encrypt.EncryptPassword(passWord)}");
            File.WriteAllLines(Auth.fileName, lines);
            return true;
        }

        else
        {
            Console.WriteLine("Incorrect Password!");
            return false;
        }

        
    }
}