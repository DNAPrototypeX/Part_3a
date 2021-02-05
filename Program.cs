using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            Console.WriteLine("1.");
            string age;
            string name;
            Console.WriteLine("What is you name?");
            name = Console.ReadLine();
            Console.WriteLine("What is your age (In years)");
            age = Console.ReadLine();
            int birthYear = DateTime.Now.Year - Convert.ToInt32(age);
            Console.WriteLine($"Your name is {name}, and you were born in the year {birthYear}.");
            Console.WriteLine("");

            //2.
            int input1;
            int input2;
            int input3;
            int sum;
            Console.WriteLine("2.");
            Console.Write("Enter the first integer: ");
            while (!Int32.TryParse(Console.ReadLine(), out input1))
                Console.WriteLine("Enter a valid integer!");
            Console.Write("Enter the second integer: ");
            while (!Int32.TryParse(Console.ReadLine(), out input2))
                Console.WriteLine("Enter a valid integer!");
            Console.Write("Enter the final integer: ");
            while (!Int32.TryParse(Console.ReadLine(), out input3))
                Console.WriteLine("Enter a valid integer!");
            sum = input1 + input2 + input3;
            Console.WriteLine($"The sum of your 3 integers is: {sum}");
            Console.WriteLine("");

            //3.
            double dist1;
            double dist2;
            double dist3;
            double avg;
            Console.WriteLine("3.");
            Console.Write("Enter the first distance: ");
            while (!double.TryParse(Console.ReadLine(), out dist1))
                Console.WriteLine("Enter a valid input!");
            Console.Write("Enter the second distance: ");
            while (!double.TryParse(Console.ReadLine(), out dist2))
                Console.WriteLine("Enter a valid input!");
            Console.Write("Enter the final distance: ");
            while (!double.TryParse(Console.ReadLine(), out dist3))
                Console.WriteLine("Enter a valid input!");
            avg = Math.Round(((dist1 + dist2 + dist3) / 3), 2);
            Console.WriteLine($"The average distance is {avg}");
            Console.WriteLine("");

            //4.
            double side1;
            double side2;
            double hyp;
            Console.WriteLine("4.");
            Console.Write("Enter the length of the first side of the triangle: ");
            while (!double.TryParse(Console.ReadLine(), out side1))
                Console.WriteLine("Enter a valid input!");
            Console.Write("Enter the length of the second side: ");
            while (!double.TryParse(Console.ReadLine(), out side2))
                Console.WriteLine("Enter a valid input!");
            hyp = Math.Round((Math.Sqrt((side1 * side1) + (side2 * side2))), 2);
            Console.WriteLine($"The length of the hypotenus of your triangle is {hyp}");
        }       
    }
}
