using System;
using System.Collections.Generic;

namespace StudentSIS
{ 
    internal class Program
    {
        static List<string> studFirstName = new List<string>();
        static List<string> studLastName = new List<string>();
        static List<string> studNo = new List<string>();
        static List<string> studContact = new List<string>();
        static List<string> studAddress = new List<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("STUDENT INFORMATION SYSTEM");

            bool sis=true;

            while (sis)
            {
                menuOpt();
                string choice = Console.ReadLine();

                switch (choice){
                    case "1":
                        studRegister();
                        break;

                }
            }
        static void menuOpt(){
                Console.WriteLine("\nMENU");
                Console.WriteLine("\n1. Register");
                Console.WriteLine("2. Manage Account");
                Console.Write("\nEnter: ");

                //Console.WriteLine("\n1. Enroll / Apply");
                //Console.WriteLine("2. Deactivate Account");
                //Console.WriteLine("3. File a Leave");
                //Console.Write("\nEnter: ");
            }
            static void studRegister(){
                Console.Write("\nFirst Name: ");
                    string fName = Console.ReadLine();
                Console.Write("Last Name: ");
                    string lName = Console.ReadLine();
                Console.Write("Student Number: ");
                    string studNum = Console.ReadLine();
                Console.Write("Contact Number: ");
                    string conNum = Console.ReadLine();
                Console.Write("Address: ");
                    string address = Console.ReadLine();

                studFirstName.Add(fName);
                studLastName.Add(lName);
                studNo.Add(studNum);
                studContact.Add(conNum);
                studAddress.Add(address);


                //Console.Write("\nConfirm Enrollment? (y/y): ");
                //    string confirmEnroll = Console.ReadLine();

                //if (confirmEnroll == "y")
                //{
                //    Console.Write("\nYou are now ENROLLED!");
                    
                //}
                //else
                //{
                //    Console.Write("Enrollment Cancelled");
                //}
                
            }
        }
    }
}
