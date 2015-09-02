using AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Address
    {
        String Name = "";
        String address1 = " ";
        String address2 = "";
        String city1;
        String state1;


        public Address(String name, String addr1, String addr2, String city, String state)
        {
            Name = name;
            address1 = addr1;
            address2 = addr2;
            city1 = city;
            state1 = state;
        }

        public void Print()
        {
            Console.WriteLine("WELCCOME ");
            Console.WriteLine("Name is  \t :" + this.Name + "\nAddress1 :\t" + this.address1 + "\nAddress2: \t" + this.address2 + "\nity: \t " + this.city1 + "\n state1: \t" + this.state1);
            Console.WriteLine();

        }
        public add_address()
        {
{
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Enter the Key:");
                    String key = Console.ReadLine();
                    Console.WriteLine("Enter the name :");
                    String name = Console.ReadLine();
                    Console.WriteLine("Enter the address :");
                    String address1 = Console.ReadLine();
                    Console.WriteLine("Enter the address :");
                    String address2 = Console.ReadLine();
                    Console.WriteLine("Enter the City :");
                    String city = Console.ReadLine();
                    Console.WriteLine("Enter the state :");
                    String state = Console.ReadLine();
                    addrbook.Add(key, new Address(name, address1, address2, city, state));
                }
                }
                
        }
        //public void add()
        //{
        //    addrbook.Add(key,new Address(Name,address1 ,address2,city1,state1));
        //}
        // public void delete()
        // {
        //     addrbook.remove;

        // }
        //if(ch_no==1)
        //{
        //    Console.WriteLine(" The Name is :", this.Name);
        //    Console.WriteLine(" Address1: ");
        //    Console.WriteLine(" Address2: " );
        //    Console.WriteLine(" City: " ); 
        //    Console.WriteLine(" State: " );


        //}





        //}


        //    public void  addNew( )
        //    {
        //        addrcreated++;
        //        List<Aadress> addressname = new List<string>();
        //        foreach(String s in address )

        //    Address( = addressname[s];

        //}
        //}

        class Program
        {
            static void Main(string[] args)
            {
                static int count=1;
                String key = "";
                //creating a dictionary to store address

                Dictionary<string, Address> addrbook = new Dictionary<string, Address>();
                Console.WriteLine("How many entries do you want to make :");
                int count;
                bool result = Int32.TryParse(Console.ReadLine(), out count);
                while (!result || count < 0)
                {
                    Console.WriteLine("Enter a valid input :");
                    result = Int32.TryParse(Console.ReadLine(), out count);

                }
                public add_address()
                //{
                //for (int i = 0; i < count; i++)
                //{
                //    Console.WriteLine("Enter the Key:");
                //    key = Console.ReadLine();
                //    Console.WriteLine("Enter the name :");
                //    String name = Console.ReadLine();
                //    Console.WriteLine("Enter the address :");
                //    String address1 = Console.ReadLine();
                //    Console.WriteLine("Enter the address :");
                //    String address2 = Console.ReadLine();
                //    Console.WriteLine("Enter the City :");
                //    String city = Console.ReadLine();
                //    Console.WriteLine("Enter the state :");
                //    String state = Console.ReadLine();
                //    addrbook.Add(key, new Address(name, address1, address2, city, state));
                //}
                //}
                //// Console.WriteLine("What address you want to Lookup");
                //String response =Console.ReadLine();
                // addrbook[response].Print();
                Console.WriteLine("Enter your choice of operatiion ");
                Console.WriteLine(" 1.ADD :\n");
                Console.WriteLine(" 2.DELETE :\n");
                Console.WriteLine("3.SEARCH : \n");
                //  Console.WriteLine( "4. UPDATE:\n");
                Int16 choice = Int16.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.WriteLine(" Enter the Name and address to add :");
                        //addrbook.Add(key, new Address(name,address1,address2,city,state));
                        add_address();
                    case 2:
                        Console.WriteLine("Enter the record to be deleted :");
                        int del = int.Parse(Console.ReadLine());
                        addrbook<del,Address>.remove[del];
                    case 3:
                        Console.WriteLine("What address you want to Lookup");
                        String response = Console.ReadLine();
                        addrbook[response].Print();


                    default:
                        Console.WriteLine("Input invalid");

                }


            }
        }
    }
}

