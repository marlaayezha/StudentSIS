using System;
using System.Collections.Generic;

namespace StudentSIS
{
    internal class Program
    {
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
                        studEnroll();
                        break;

                }
            }
        static void menuOpt(){
                    Console.WriteLine("\n1. Enroll / Apply");
                    Console.WriteLine("2. Deactivate Account");
                    Console.WriteLine("3. File a Leave");
                    Console.WriteLine("4. Rules");
                    Console.Write("\nEnter: ");
        }
        static void studEnroll(){
                Console.Write("\nFirst Name: ");
                    string fName = Console.ReadLine();
                Console.Write("Last Name: ");
                    string lName = Console.ReadLine();
                Console.Write("Student Number: ");
                    string studNum = Console.ReadLine();
                Console.Write("Contact Number: ");
                    int contactNum = int.Parse(Console.ReadLine());
                Console.Write("Address: ");
                    string address = Console.ReadLine();

                Console.Write("Confirm Enrollment? (Y/N): ");
                    string confirmEnroll = Console.ReadLine();

                if (confirmEnroll == "y")
                {
                    Console.Write("You are now ENROLLED!");
                }
                else
                {
                    Console.Write("Enrollment Cancelled");
                }
                
            }
        }
    }
}
