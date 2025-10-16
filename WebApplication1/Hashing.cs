using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace WebApplication1
{
    public static class Hashing
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Enter username");
            string? username = Console.ReadLine();

            Console.Write("Enter password");
            string password = Console.ReadLine();

            System.Console.WriteLine(HashPassword(password));
        }

        static string HashPassword(string password)
        {
            using (SHA256 sha256hash = SHA256.Create())
            {

                byte[] hashBytes = sha256hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

            }
        }


    }
}