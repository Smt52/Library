﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Librarian : User
    {
        public Librarian(string name, string email, string password) : base(name, email, password)
        {
        }

        public override bool LogIn()
        {
            Console.Write("Please enter your email:");
            string email = Console.ReadLine();
            Console.Write("Please enter your password:");
            string password = Console.ReadLine();

            if (email == null || password == null)
            {
                Console.WriteLine("Email or password cannot be empty.");
                return false;
            }
            if (email != _email || password != _password)
            {
                Console.WriteLine("Email or password is wrong.");
                return false;
            }

            return true;
        }

        public void NotifyBookCount(BookWrapper bookWrapper)
        {
            Console.WriteLine("Less than two copies of this book remain in the library.");
        }
    }
}