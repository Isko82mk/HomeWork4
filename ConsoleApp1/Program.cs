using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime curentDate = DateTime.Now;
            DateTime addTreeDays = curentDate.AddDays(3); // added 3days
            DateTime addMonth = addTreeDays.AddMonths(1); //added one month from now
            DateTime monthAndThreeDays = addMonth.AddDays(3);//month and three days from now;
            DateTime yearAgo = curentDate.AddYears(-1);// one year ago
            DateTime yearAnd2MonAgo = yearAgo.AddMonths(-2);//one year nad 2 months ago

            string thisMont = DateTime.Now.ToString("MM");//only this MONTH
            string thisYear = DateTime.Now.ToString("yyyy");//only this YEAR





            Console.WriteLine(curentDate);
            Console.WriteLine(addTreeDays);
            Console.WriteLine(addMonth);
            Console.WriteLine(monthAndThreeDays);
            Console.WriteLine(yearAgo);
            Console.WriteLine(yearAnd2MonAgo);

            Console.WriteLine(thisMont);
            Console.WriteLine(thisYear);



            Console.ReadLine();
        }
    }
}
