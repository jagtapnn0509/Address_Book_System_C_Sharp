using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book_System
{
    class AdddressBookBuilder
    {
        public List<Data> list;
        public AdddressBookBuilder()
        {
            this.list = new List<Data>();
        }
        public void AddContact (Data dataobj)
        {
            this.list.Add(dataobj); 
        }
        public void Display_Contacts()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------Contacts in Address Books System--------------");

            foreach (var i in this.list)
            {
                Console.WriteLine($"First Name :{i.First_Name} \nLast Name : {i.Last_Name} \nAddress : {i.Address} \nCity : {i.City} \nState : {i.State} \nZip : {i.Zip} \nPhone No : {i.Phone_No} \nEmail : {i.Email}");
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
            }
        }

        public int Update_Contact(string FirstName)
        {
            int index = list.FindIndex(data => data.First_Name.Equals(FirstName));
            return index;
        }
    }
}
