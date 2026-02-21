namespace StudentSIS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("STUDENT INFORMATION SYSTEM");
            Console.WriteLine("\n1. Enroll / Apply");
            Console.WriteLine("2. Deactivate Account");
            Console.WriteLine("3. File a Leave");
            Console.WriteLine("4. Rules");
            Console.Write("\nEnter: ");
            string studentChoice = Console.ReadLine();

            if (studentChoice == "1")
            {
                Console.Write("\nFirst Name: ");
                string fName = Console.ReadLine();
                Console.Write("Last Name: ");
                string lName = Console.ReadLine();
                Console.Write("Student Number: ");
                string studNum = Console.ReadLine();
                Console.Write("Contact Number: ");
                string studNum = Console.ReadLine();
                Console.Write("Address: ");
                string studNum = Console.ReadLine();
            }
        }
    }
}
