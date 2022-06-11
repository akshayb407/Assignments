using System;

namespace EmployeePayRoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckEmployeePresentOrAbsent();


        }
         public static void CheckEmployeePresentOrAbsent()
        {
            Console.WriteLine("Welcome to Employee Pay Roll");
            Random r = new Random();
            int number = r.Next(0,2);
            if (number == 0)
            {
                Console.WriteLine("Employee is Absent");

            }
            else
            {
                Console.WriteLine("Employee is Present");

            }
        }
    }
}
