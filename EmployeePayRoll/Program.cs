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
            int wagePerHour = 20;
            int fullDayhour = 8;
            int totalWage = 0;
            int number = r.Next(0,2);
            if (number == 0)
            {
                Console.WriteLine("Employee is Absent");
              

            }
            else
            {
                Console.WriteLine("Employee is Present");
                totalWage = wagePerHour * fullDayhour;
                Console.WriteLine("Employee's total wage is:" + totalWage);

            }
        }
    }
}
