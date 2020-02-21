using System;

namespace Ref_and_Out
    /* "Ref" tells the compiler that the object is initialized before entering the function,
     * while "Out" tells the compiler that the object will be initialized inside the function.
     * So while "Ref" is two-ways, "Out" is out-only. */


{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            string message = MakeGreeting(name);
            Console.WriteLine(message);

            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();
            int nameLength = FullName(name, lastName, out string fullname);
            Console.WriteLine("Your full name is " + fullname + ". It has this many letter: " + nameLength);
            
            Capitalize(ref fullname);
            Console.WriteLine("You name in uppercase: " + fullname);
            
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static int FullName(string firstName, string lastName, out string fullName)
        {
            fullName = firstName + " " + lastName;
            return fullName.Length;

        }

        static void Capitalize(ref string fullname)
        {
            fullname = fullname.ToUpper();
        }
        static string MakeGreeting(string name)
        {
            return "Hello " + name + "!!";
        }
    }
}


