using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Good Afternoon. Please enter your first name");
            string fname = Console.ReadLine();

            Console.WriteLine("Please enter your last name");
            string lname = Console.ReadLine();
            
            Console.WriteLine("Please enter your address");
            string address = Console.ReadLine();

            Console.WriteLine("Please enter your email address");
            string email = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your 4 digit pin number");
            int pin = int.Parse(Console.ReadLine());

            /*Give a heading*/
            string heading = "************ Details *************";
            /* /n = new line*/         
            Console.WriteLine(heading + "\nName:" + fname + " " + lname);
            Console.WriteLine("Age:" + " " + age); 
            Console.WriteLine("Address:" + " " + address);
            Console.WriteLine("Email:" + " " + email);
            Console.WriteLine("Thank you!");

            Console.ReadLine();











        }
    }
}
