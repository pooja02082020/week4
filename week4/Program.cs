using System;

namespace week4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1Asks user for age and calcualte birth year
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            int current_year = DateTime.Now.Year;
            Console.WriteLine(current_year);
            int DOB = current_year - age;

            Console.WriteLine("Your date of birth is {0}", DOB);



            //Q23rd degree polynomial 
            Console.Write("Enter the value of a (int) : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of b (int) : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of c (int) : ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of x (double) :");
            double x = double.Parse(Console.ReadLine());
            // double value = ((a + b) / 2.0) * Math.Pow(x, 3) + Math.Pow(a + b, 2) * Math.Pow(x, 2) + a + b + c;
            double value = (((a + b) / 2.0) * x * x * x) + ((a * a + 2 * a * b + b * b) * x * x) + a + b + c;
            Console.WriteLine("The value of polynomial is {0}", value);



            //Q3Swap two variables 
            Console.WriteLine("Enter x: ");
            string x1 = Console.ReadLine();

            Console.WriteLine("Enter y: ");
            string y = Console.ReadLine();
            string temp;
            temp = x1;
            x1 = y;
            y = temp;
            Console.WriteLine("Before Swapping : x : {0} ; x : {1}", temp, x1);
            Console.WriteLine("After Swapping : y : {0} ; y : {1}", x1, temp);



            //Q4
            Console.Write("How much did you receive money ($)? ");
            double totalMoney = Convert.ToDouble(Console.ReadLine());
            //three quarter 
            double booksAndSupplies = totalMoney * 0.75;

            double remainingMoney = totalMoney - booksAndSupplies;
            //rem amt = x * 2 + y * 4 +  z * 3 +  change
            int equalAmt = (int)remainingMoney / 3;
            Console.WriteLine(equalAmt);
            int coffees = (int)(equalAmt / 2);
            int flashComputers = (int)(equalAmt / 4);
            int subwayTickets = (int)(equalAmt / 3);
            double whiteRoses = remainingMoney - (2 * coffees + 4 * flashComputers + 3
                * subwayTickets);

            Console.WriteLine("Book and Supplies: {0} $ ", booksAndSupplies);
            Console.WriteLine("You can then buy:");
            Console.WriteLine("{0} coffees", coffees);
            Console.WriteLine("{0} Flash Computer Numbers", flashComputers);
            Console.WriteLine("{0} subway Tickets",subwayTickets);
            Console.WriteLine("and you will have {0} dollars for the white roses.",whiteRoses);

            //calculate area and perimeter of circle
            double area, perimeter;
            double pi = 3.14;
            Console.Write("Enter the radius of circle");
            double r = double.Parse(Console.ReadLine());
            area = pi * r * r;
            perimeter = 2 * pi * r;
            Console.WriteLine("The area and perimeter of circle with radius {0}  is  {1} and {2} respectively", r, area, perimeter);
        }
    }

}
