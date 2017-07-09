using System;

namespace LateBinding_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Data: ");
            String data = Console.ReadLine();

            Cipher cipher = new Cipher();
            String enc = cipher.Encrypt(data);
            String dec = cipher.Decrypt(enc);
            Console.WriteLine("Offset(Default) Cipher: ");
            Console.WriteLine(enc);
            Console.WriteLine(dec);
            Console.WriteLine();

            cipher = new SubstitutionCipher();
            enc = cipher.Encrypt(data);
            dec = cipher.Decrypt(enc);
            Console.WriteLine("Substitution Cipher: ");
            Console.WriteLine(enc);
            Console.WriteLine(dec);
            Console.WriteLine();

        }
    }
}
