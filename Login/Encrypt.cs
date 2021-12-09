//Encrypts passwords
using System.Security.Cryptography;
using System.Text;
public class Encrypt
    {
     public static string EncryptPassword(string password) //takes a string (password) and encrypts it
        {
            MD5 md5 = MD5.Create(); //creates MD5 instance
            UTF8Encoding utf8 = new UTF8Encoding(); //creates utf8 instance
            byte[] data = md5.ComputeHash(utf8.GetBytes(password)); //Uses the md5 instance to encrypt passwords using ComputeHash, which Computes the hash value for the specified byte array. 
            //utf8.GetBytes encodes a set of characters from the specified String into the specified byte array.
            return Convert.ToBase64String(data); //returns the encrypted password converted from a byte to string
        }
    }
