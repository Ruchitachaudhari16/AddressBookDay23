﻿using System;
using System.Collections.Generic;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC4 Ability to delete aperson using person's name - Use Console to delete a person

            Contacts a = new Contacts();
            Console.WriteLine("Welcome to address book program");
            while (true)
            {
                Console.WriteLine("Enter Choice:");
                Console.WriteLine("1.Add Contact \n 2.Edit Contact \n 3.Delete Contact \n 4.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        a.AddContact();
                        break;
                    case 2:
                        a.Edit();
                        break;
                    case 3:
                        a.Delete();
                        break;
                       
                    case 4:
                        break;
                }
                if (choice == 4)
                {
                    break;
                }
            }
        }
    }
    }
    
