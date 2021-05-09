using System;
using System.Collections.Generic;

namespace Address_Book_System
{
    class Program
    {
        /*String First_Name, Last_Name, Address, City, State;
        int Zip;
        long Phone_No;*/

        public class Data
        {
            public String First_Name { get; set; }
            public String Last_Name { get; set; }
            public String Address { get; set; }
            public String  City { get; set; }
            public String State { get; set; }
            public int Zip { get; set; }
            public long Phone_No { get; set; }
            /*public Data(string First_Name, string Last_Name, string Address, string City, string State, int Zip, long Phone_No)
            {
                this.First_Name = First_Name;
                this.Last_Name = Last_Name;
                this.Address = Address;
                this.City = City;
                this.State = State;
                this.Zip = Zip;
                this.Phone_No = Phone_No;
                Console.WriteLine("Constructor "+First_Name);
            }
            */
        }

        public static List<Data> list = new List<Data>();
        /*public void add(string First_Name, string Last_Name, string Address, string City, string State, int Zip, long Phone_No) {
            list.Add(new Data(First_Name, Last_Name, Address, City, State, Zip, Phone_No));
            Console.WriteLine("add function sucs");
        }*/

        public void Create_Contacts()
        {
            int exit = 0;
            Data d = new Data();
            while (exit==0) {
                
                Console.Write("Enter the First Name : ");
                d.First_Name = (Console.ReadLine());

                Console.Write("Enter the Last Name : ");
                d.Last_Name = (Console.ReadLine());

                Console.Write("Enter the Address : ");
                d.Address = (Console.ReadLine());

                Console.Write("Enter the City : ");
                d.City = (Console.ReadLine());

                Console.Write("Enter the State : ");
                d.State = (Console.ReadLine());

                Console.Write("Enter the Zip : ");
                d.Zip = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the Phone No : ");
                d.Phone_No = Convert.ToInt64(Console.ReadLine());

                //add(First_Name, Last_Name, Address, City, State, Zip, Phone_No);
                list.Add(d);
                Console.Write("do you want to exit if yes enter 1 ortherwise enter 0  ");
                exit = Convert.ToInt32(Console.ReadLine());
            }
            
        }

        public void Display_Contacts(Data d)
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------Contacts in Address Books System--------------");
            /*for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
                //Data temp = list.Get;
            }
            foreach (Data l in list) {
                Console.WriteLine($"Author: {l.GetType()}");
            }*/
            Console.WriteLine("First Name: " + d.First_Name);
            //Console.WriteLine("First name is :" + First_Name + "\nLast name is :" + Last_Name + "\nAddress is :" + Address + "\nCity is :" + City + "\nState is :" + State + "\nZip code is :" + Zip + "\nPhone no is :" + Phone_No);
        }

       
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Program addressbookpbj = new Program();
            addressbookpbj.Create_Contacts();
            //addressbookpbj.Display_Contacts();

            
    }
    }
}
