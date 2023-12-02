using System;

public class Encrypter
{
    public static string Encrypt(string text)
    {
        char[] chars = text.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            chars[i] = (char)(chars[i] + 1);
        }
        return new string(chars);
    }

    public static string Decrypt(string text)
    {
        char[] chars = text.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            chars[i] = (char)(chars[i] - 1);
        }
        return new string(chars);
    }
}

class Program
{
    static void Main()
    {
        string originalText = "Hello";
        string encryptedText = Encrypter.Encrypt(originalText);
        Console.WriteLine("Encrypted text: " + encryptedText);

        string decryptedText = Encrypter.Decrypt(encryptedText);
        Console.WriteLine("Decrypted text: " + decryptedText);
    }
}