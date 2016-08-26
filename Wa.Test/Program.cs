using System;

namespace Wa.Test
{
    public class Program
    {
       // private static string pkey = "smkldospdosldaaa";//key，可自行修改
       // private static string piv = "0392039203920300"; //偏移量,可自行修改
        public static void Main(string[] args)
        {
            var encrytpData =CommonEncrypt.Encrypt("abc");
            Console.WriteLine(encrytpData);

            var decryptData = CommonEncrypt.Decrypt("gR2in2uzMOZcftlFQm8tDw==");
            Console.WriteLine(decryptData);

            Console.ReadLine();
        }
    }
}
