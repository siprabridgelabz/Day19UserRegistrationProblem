﻿using System.Xml.Linq;

namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Page!!");
            Console.WriteLine("********************************");
            UserRegistrationCode obj = new UserRegistrationCode();
            Console.WriteLine("Enter the First Name:");
            string FName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name:");
            string LName = Console.ReadLine();
            Console.WriteLine("Enter your Email Id:");
            string MailId = Console.ReadLine();
            Console.WriteLine("Enter your Mobile Number:");
            string MobNum = Console.ReadLine();

            Console.WriteLine(obj.ValidateFName(FName));
            Console.WriteLine(obj.ValidateFName(LName));
            Console.WriteLine(obj.ValidateEmail(MailId));
            Console.WriteLine(obj.ValidateMobNum(MobNum));
        }

    }
    
}


