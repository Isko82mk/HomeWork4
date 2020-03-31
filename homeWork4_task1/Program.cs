using System;

namespace homeWork4_task1
{
    class Program
    {
        static void Main(string[] args)
        {

            string hello = "Hello from SEDC Codecademy v7.0";
            //char[] hChars = hello.ToCharArray();
            //Console.WriteLine(hChars.Length);
            Console.WriteLine("Enter number beatwin 1 and 31");
            int userImput = Convert.ToInt32(Console.ReadLine());

            if (userImput <= 31)
            {
              

                string subString = hello.Substring(0, userImput);
                Console.WriteLine(subString);
                Console.WriteLine($"The length of the new string is {subString.Length}");

            }
            else if (userImput > 31)
            {

                Console.WriteLine("Eror....Enter number beatwin 1 and 31");
            }





            Console.ReadLine();



        }
    }
}
