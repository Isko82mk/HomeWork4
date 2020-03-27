using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your date of birth");

            Console.WriteLine("Enter year");
            string yearInout = Console.ReadLine();

            Console.WriteLine("Enter month");
            string monthInout = Console.ReadLine();

            Console.WriteLine("Enter day");
            string dayInout = Console.ReadLine();

            int year = int.Parse(yearInout);
            int mont = int.Parse(monthInout);
            int day = int.Parse(dayInout);


            DateTime birthDay = new DateTime(year, mont, day);

            Console.WriteLine(CalculateAge(birthDay));

            Console.ReadLine();
        }


        static int CalculateAge(DateTime birthDay)
        {
            DateTime rightNow = DateTime.Now;

            int age = rightNow.Year - birthDay.Year;

            if (rightNow.Month < birthDay.Month || (rightNow.Month == birthDay.Month && rightNow.Day < birthDay.Day))
            {
                age--;
            }
            return age;
        }





    }
}
