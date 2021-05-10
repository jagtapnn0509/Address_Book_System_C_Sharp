﻿using System;
using System.Collections.Generic;

namespace Address_Book_System
{
    class Program
    {
        public void Create_Contacts(Data contact)
        {
            Console.Write("Enter the First Name : ");
            contact.First_Name = (Console.ReadLine());

            Console.Write("Enter the Last Name : ");
            contact.Last_Name = (Console.ReadLine());

            Console.Write("Enter the Address : ");
            contact.Address = (Console.ReadLine());

            Console.Write("Enter the City : ");
            contact.City = (Console.ReadLine());

            Console.Write("Enter the State : ");
            contact.State = (Console.ReadLine());

            Console.Write("Enter the Zip : ");
            contact.Zip = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Phone No : ");
            contact.Phone_No = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter the Email Id : ");
            contact.Email = (Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AdddressBookBuilder addressbook = new AdddressBookBuilder();
            Program addressbookpbj = new Program();
            int choice = 1;
            while (choice != 3)
            {
                Console.WriteLine("Menu : \n 1.Add_Contact \n 2.Display_Contact \n 3.Exit ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Data contact = new Data();
                        addressbookpbj.Create_Contacts(contact);
                        addressbook.AddContact(contact);
                        Console.WriteLine("Contact Added Successfully.");
                        break;
                    case 2:
                        addressbook.Display_Contacts();
                        break;
                    case 3:
                        Console.WriteLine("Program Exited");
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
               
            }
        }
    }
}
